using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection;
using System.Management;

namespace ProcessManipulation
{
    public partial class MainForm : Form
    {
         List<Process> processes = new List<Process>();
         int counter = 0;
         delegate void ProcessDelegate(Process process);
                        
         public MainForm()
         {
              InitializeComponent();
              LoadAvailabAssemblies();
         }
         private void process_Exited(object sender, EventArgs e)
         {
                Process process = sender as Process;
                listBoxStartAss.Items.Remove(process.ProcessName);
                listBoxAssembly.Items.Add(process.ProcessName);
                processes.Remove(process);
                counter--;
                for (int i = 0; i < processes.Count; i++)
                    SetChileWindows(process.MainWindowHandle, $"Child {i + 1}");
                
         }
         void LoadAvailabAssemblies()
         {
              listBoxAssembly.Items.Clear();
              string except = new FileInfo(Application.ExecutablePath).Name.Split('.').First();// путь к файлу
              string[] files = Directory.GetFiles(Application.StartupPath, "*.exe");
              for (int i = 0; i < files.Length; i++)
              {
                  listBoxAssembly.Items.Add(files[i].Split('\\').Last().Split('.').First());
              }
              listBoxAssembly.Items.Remove(except);
         }
         void RunProcess(string assemblyName)
         {
             Process process = Process.Start(assemblyName);
             processes.Add(process);
             if (Process.GetCurrentProcess().Id == GetParentProcessId(process.Id))
             {
                  MessageBox.Show($"{process.ProcessName}является дочерним процессом");
             }
             process.EnableRaisingEvents = true;
             process.Exited += process_Exited;

             SendMessage(process.MainWindowHandle, WM_SETTEXT, (System.IntPtr)0, $"Child process # {processes.Count}");
             //SetChileWindows(process.MainWindowHandle, $"Child process #{processes.Count}");
             listBoxStartAss.Items.Add(process.ProcessName);
             listBoxAssembly.Items.Remove(process.ProcessName);
         }
         void ExicuteOnProcessName(string name, ProcessDelegate func)
         {
             Process[] processes = Process.GetProcessesByName(name);
             foreach (Process proc in processes)
             {
                  if (Process.GetCurrentProcess().Id == GetParentProcessId(proc.Id)) func(proc);
             }
         }
         int GetParentProcessId(int id)
         {
             int parent;
             using (ManagementObject obj = new ManagementObject("win32_process.handle=" + id.ToString()))
             {
                 obj.Get();
                 parent = Convert.ToInt32(obj["ParentProcessId"]);
             }
             return parent;
         }
         void SetChileWindows(IntPtr handle, string text)
         {
             SendMessage(handle, WM_SETTEXT, (System.IntPtr)0, text);
         }

         const uint WM_SETTEXT = 0x0C;
         [DllImport("user32.dll")]
         public static extern IntPtr SendMessage(IntPtr hwnd, uint uMsg, IntPtr wParam, [MarshalAs(UnmanagedType.LPStr)]string lParam);

         private void buttonStart_Click(object sender, EventArgs e)
         {
              if (listBoxAssembly.SelectedItem != null)
                RunProcess(listBoxAssembly.SelectedItem.ToString());
         }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            foreach (Process proc in processes)
            {
                proc.CloseMainWindow();
                proc.Close();
            }
        }
        void Kill(Process process)
        {
            process.Kill();
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            
            ExicuteOnProcessName(listBoxStartAss.SelectedItem.ToString(), Kill);
            //listBoxStartAss.Items.Clear();
            listBoxAssembly.Items.Add(listBoxAssembly);

        }
    }
    
}
