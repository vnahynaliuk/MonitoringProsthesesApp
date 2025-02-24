using MonitoringProsthesesApp.AppCode;
using MonitoringProsthesesApp.Forms.Controls;
using MonitoringProsthesesApp.Forms.Dictionary;
using MonitoringProsthesesApp.Forms.Raport;
using MonitoringProsthesesApp.Forms.Systems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitoringProsthesesApp {
  public partial class MonitoringProsthesesMDI : Form {

    public MonitoringProsthesesMDI() {
      InitializeComponent();
    }

    public void CloseAllWindows() {
      Form[] childArray = this.MdiChildren;
      foreach (Form childForm in childArray) {
        childForm.Close();
      }
    }

    private void пацієнтиToolStripMenuItem_Click(object sender, EventArgs e) {
      CloseAllWindows();
      PatientsForm patientsForm = new PatientsForm();
      patientsForm.MdiParent = this;
      patientsForm.WindowState = FormWindowState.Maximized;
      patientsForm.Show();
    }

    private void встановленняПротезуToolStripMenuItem_Click(object sender, EventArgs e) {
      CloseAllWindows();
      InstallationProsthesesForm installationProsthesesForm = new InstallationProsthesesForm();
      installationProsthesesForm.MdiParent = this;
      installationProsthesesForm.WindowState = FormWindowState.Maximized;
      installationProsthesesForm.Show();
    }

    private void типиПротезівToolStripMenuItem_Click(object sender, EventArgs e) {
      CloseAllWindows();
      TypesProsthesesForm typesProsthesesForm = new TypesProsthesesForm();
      typesProsthesesForm.MdiParent = this;
      typesProsthesesForm.WindowState = FormWindowState.Maximized;
      typesProsthesesForm.Show();
    }

    private void протезиToolStripMenuItem_Click(object sender, EventArgs e) {
      CloseAllWindows();
      ProsthesesForm prosthesesForm = new ProsthesesForm();
      prosthesesForm.MdiParent = this;
      prosthesesForm.WindowState = FormWindowState.Maximized;
      prosthesesForm.Show();
    }

    private void вдстежуванняСтенуПротезуToolStripMenuItem_Click(object sender, EventArgs e) {
      CloseAllWindows();
      StatusTrackingForm statusTrackingForm = new StatusTrackingForm();
      statusTrackingForm.MdiParent = this;
      statusTrackingForm.WindowState = FormWindowState.Maximized;
      statusTrackingForm.Show();
    }

    private void вихідToolStripMenuItem_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void користувачіToolStripMenuItem_Click(object sender, EventArgs e) {
      if (LoginForm.CurrentUser.RoleId == 1) {
        CloseAllWindows();
        UsersForm usersForm = new UsersForm();
        usersForm.MdiParent = this;
        usersForm.WindowState = FormWindowState.Maximized;
        usersForm.Show();
      } else {
        MessageBox.Show(NamesMy.MessageBoxExaption.YouDontHavePermission);
      }
    }

    private void подіїToolStripMenuItem_Click(object sender, EventArgs e) {
      if (LoginForm.CurrentUser.RoleId == 1) {
        CloseAllWindows();
        SystemLogForm systemLogForm = new SystemLogForm();
        systemLogForm.MdiParent = this;
        systemLogForm.WindowState = FormWindowState.Maximized;
        systemLogForm.Show();
      } else {
        MessageBox.Show(NamesMy.MessageBoxExaption.YouDontHavePermission);
      }
    }

    private void поТипуПротезуToolStripMenuItem_Click(object sender, EventArgs e) {
      CloseAllWindows();
      TypesProsthesesRaportForm typesProsthesesRaportForm = new TypesProsthesesRaportForm();
      typesProsthesesRaportForm.MdiParent = this;
      typesProsthesesRaportForm.WindowState = FormWindowState.Maximized;
      typesProsthesesRaportForm.Show();
    }

    private void встановліПротезиЗаПеріодЧасуToolStripMenuItem_Click(object sender, EventArgs e) {
      CloseAllWindows();
      InstallForPeriodDateForm installForPeriodDateForm = new InstallForPeriodDateForm();
      installForPeriodDateForm.MdiParent = this;
      installForPeriodDateForm.WindowState = FormWindowState.Maximized;
      installForPeriodDateForm.Show();
    }

    private void відмовиПротезівToolStripMenuItem_Click(object sender, EventArgs e) {
      CloseAllWindows();
      ErorRaportForm erorRaportForm = new ErorRaportForm();
      erorRaportForm.MdiParent = this;
      erorRaportForm.WindowState = FormWindowState.Maximized;
      erorRaportForm.Show();
    }

    private void відслідковуванняДинамікиПротезуПацієнтаToolStripMenuItem_Click(object sender, EventArgs e) {
      CloseAllWindows();
      StatisticRaportForm statisticRaportForm = new StatisticRaportForm();
      statisticRaportForm.MdiParent = this;
      statisticRaportForm.WindowState = FormWindowState.Maximized;
      statisticRaportForm.Show();
    }

    private void MonitoringProsthesesMDI_Resize(object sender, EventArgs e) {
      this.BackgroundImage = Properties.Resources.back;
    }
  }
}
