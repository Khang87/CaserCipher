using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace _22_CaserCipher
{
    public partial class Login3 : Form
    {
        public Login3()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string dataSource = $"(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={txtHost.Text.Trim()})(PORT={txtPort.Text.Trim()}))(CONNECT_DATA=(SID={txtSid.Text.Trim()})))";
            string connStr = $"Data Source={dataSource};User Id={txtUser.Text.Trim()};Password={txtPassword.Text};";
            try
            {
                var asm = Assembly.Load("Oracle.ManagedDataAccess");
                var connType = asm.GetType("Oracle.ManagedDataAccess.Client.OracleConnection", true);
                using (var conn = (IDisposable)Activator.CreateInstance(connType, connStr))
                {
                    connType.GetMethod("Open").Invoke(conn, null);
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


