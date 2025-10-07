using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace _22_CaserCipher
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string host = txtHost.Text.Trim();
            string port = txtPort.Text.Trim();
            string sid = txtSid.Text.Trim();
            string user = txtUser.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(host) || string.IsNullOrEmpty(port) || string.IsNullOrEmpty(sid))
            {
                MessageBox.Show("Please fill Host, Port, and Sid.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dataSource = $"(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={host})(PORT={port}))(CONNECT_DATA=(SID={sid})))";
            string connStr = $"Data Source={dataSource};User Id={user};Password={password};";

            // Use reflection to avoid hard dependency if Oracle ManagedDataAccess is not present at design-time
            try
            {
                var asm = Assembly.Load("Oracle.ManagedDataAccess");
                var connType = asm.GetType("Oracle.ManagedDataAccess.Client.OracleConnection", throwOnError: true);
                using (var conn = (IDisposable)Activator.CreateInstance(connType, connStr))
                {
                    var openMethod = connType.GetMethod("Open");
                    openMethod.Invoke(conn, null);

                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (TargetInvocationException tie)
            {
                MessageBox.Show($"Login failed: {tie.InnerException?.Message ?? tie.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


