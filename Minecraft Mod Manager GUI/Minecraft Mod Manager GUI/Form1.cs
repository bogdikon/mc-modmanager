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

namespace Minecraft_Mod_Manager_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(".\\config.cfg") == false) {
                System.Diagnostics.Process.Start("first_start.cmd");
            }
            System.Collections.Generic.IEnumerable<string> path;
            path = File.ReadLines("config.cfg");
            var path1 = string.Join("", path.ToArray());
            path1 = path1.Replace("\n", "");
            path1 = path1.Replace(" ", "");
            path1 = path1.Trim();
            path1 = path1 + "mods\\";
            string[] allfolders = Directory.GetDirectories(path1);
            foreach (string folder in allfolders)
            {
                string packName = Path.GetFileName(folder);
                packList.Items.Add(packName);
            }
        }

        private void modList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (packList.SelectedItem == null)
            {
                return;
            }
            System.Collections.Generic.IEnumerable<string> path;
            path = File.ReadLines("config.cfg");
            var path1 = string.Join("", path.ToArray());
            path1 = path1.Replace("\n", "");
            path1 = path1.Replace(" ", "");
            path1 = path1.Trim();
            path1 = path1 + "mods\\";
            IniFile ini = new IniFile(path1 + packList.SelectedItem.ToString() + "\\modpack.meta");
            var packName = ini.IniReadValue("modpack", "packName");
            var packDesc = ini.IniReadValue("modpack", "packDesc");
            var packVersion = ini.IniReadValue("modpack", "version");
            packInfoName.Text = "Pack name: " + packName;
            packInfoDesc.Text = "Pack description: " + packDesc;
            packInfoVersion.Text = "Minecraft version: " + packVersion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (packList.SelectedItem == null)
            {
                MessageBox.Show("Nothing selected!", "Error", MessageBoxButtons.OK);
                return;
            }
            System.Collections.Generic.IEnumerable<string> path;
            path = File.ReadLines("config.cfg");
            var path1 = string.Join("", path.ToArray());
            path1 = path1.Replace("\n", "");
            path1 = path1.Replace(" ", "");
            path1 = path1.Trim();
            path1 = path1 + "mods\\";
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            proc.StartInfo.FileName = "mod_swap.cmd";
            proc.StartInfo.Arguments = path1 + packList.SelectedItem.ToString();
            proc.StartInfo.RedirectStandardError = false;
            proc.StartInfo.RedirectStandardOutput = false;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();
            proc.WaitForExit();
            // System.Diagnostics.Process.Start("mod_swap.cmd", path1 + packList.SelectedItem.ToString());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("made by Bogdikon_, version: 1.0", "About", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            packList.ClearSelected();
            packList.Items.Clear();
            System.Collections.Generic.IEnumerable<string> path;
            path = File.ReadLines("config.cfg");
            var path1 = string.Join("", path.ToArray());
            path1 = path1.Replace("\n", "");
            path1 = path1.Replace(" ", "");
            path1 = path1.Trim();
            path1 = path1 + "mods\\";
            string[] allfolders = Directory.GetDirectories(path1);
            foreach (string folder in allfolders)
            {
                string packName = Path.GetFileName(folder);
                packList.Items.Add(packName);
            }
        }

    }
}


public class IniFile
{
    public string path;

    [DllImport("kernel32")]
    private static extern long WritePrivateProfileString(string section,
        string key, string val, string filePath);
    [DllImport("kernel32")]
    private static extern int GetPrivateProfileString(string section,
        string key, string def, StringBuilder retVal,
        int size, string filePath);


    public IniFile(string iniPath)
    {
        path = iniPath;
    }

    public void IniWriteValue(string section, string key, string value)
    {
        WritePrivateProfileString(section, key, value, path);
    }

    public string IniReadValue(string section, string key)
    {
        StringBuilder temp = new StringBuilder(255);
        int i = GetPrivateProfileString(section, key, "", temp, 255, path);
        return temp.ToString();
    }
}
