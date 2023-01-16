using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows;
namespace BMRA_Launch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                ProcessStartInfo javaProcessInfo;
                Process javaProcess;

                javaProcessInfo = new ProcessStartInfo("cmd.exe", "/c " + "java -version")
                {
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true
                };

                javaProcess = Process.Start(javaProcessInfo);
                string output = javaProcess.StandardOutput.ReadToEnd();
                output += javaProcess.StandardError.ReadToEnd();
                javaProcess.WaitForExit();

                if (output.ToLower().Contains("64-bit") == false)
                {
                    MessageBoxResult result = MessageBox.Show("The Dashboard launcher cannot detect java 64-Bit java." + System.Environment.NewLine +
                                              "If the dashboard does not load, it may indicate a problem with java installation" + System.Environment.NewLine + System.Environment.NewLine +
                                              "Do you wish to continue?" + System.Environment.NewLine, "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

                    if (result == MessageBoxResult.Yes)
                    {
                        this.launch();
                    }
                    else
                    {
                        System.Environment.Exit(1);
                    }
                }
                else
                {
                    this.launch();
                }
            }
            catch( Exception e )
            {
                MessageBox.Show( e.Message );
            }         
            
        }

        private void launch()
        {
            try
            {
                ProcessStartInfo processInfo;
                Process process;

                processInfo = new ProcessStartInfo("cmd.exe", "/c " + "Launch.bat")
                {
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardError = false,
                    RedirectStandardOutput = false
                };

                process = Process.Start(processInfo);
            }
            catch( Exception e )
            {
                MessageBox.Show( e.Message );
                System.Environment.Exit(1);
            }
        }
    }
}
