using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace grad_proj
{
    public partial class Form2 : Form
    {
        void Summer()
        {

            if (degree == "Professor")
                Summervalue = Double.Parse(BSal) * 2;
            else if (degree == "Assistant professor")
                Summervalue = Double.Parse(BSal) * 1.5;
            else if (degree == "lecturer")
                Summervalue = Double.Parse(BSal) * 1.3;
            else if (degree == "lecturer assistant")
                Summervalue = Double.Parse(BSal) * 0.9;
            else if (degree == "Demonstrater")
                Summervalue = Double.Parse(BSal) * 0.5;


        }
        void Depu()
        {

            if (degree == "Professor")
                Depuvalue = Double.Parse(BSal) * 5;
            else if (degree == "Assistant professor")
                Depuvalue = Double.Parse(BSal) * 3.5;
            else if (degree == "lecturer")
                Depuvalue = Double.Parse(BSal) * 2.3;
            else if (degree == "lecturer assistant")
                Depuvalue = Double.Parse(BSal) * 1.9;
            else if (degree == "Demonstrater")
                Depuvalue = Double.Parse(BSal) * 1.5;


        }
        void Controle()
        {

            if (degree == "Professor")
                Controlevalue = Double.Parse(BSal) * 2;
            else if (degree == "Assistant professor")
                Controlevalue = Double.Parse(BSal) * 1.5;
            else if (degree == "lecturer")
                Controlevalue = Double.Parse(BSal) * 1.3;
            else if (degree == "lecturer assistant")
                Controlevalue = Double.Parse(BSal) * 0.9;
            else if (degree == "Demonstrater")
                Controlevalue = Double.Parse(BSal) * 0.7;


        }
        void Over()
        {

            if (degree == "Professor")
                Overvalue = Double.Parse(BSal) * 1;
            else if (degree == "Assistant professor")
                Overvalue = Double.Parse(BSal) * 0.9;
            else if (degree == "lecturer")
                Overvalue = Double.Parse(BSal) * .7;
            else if (degree == "lecturer assistant")
                Overvalue = Double.Parse(BSal) * 0.5;
            else if (degree == "Demonstrater")
                Overvalue = Double.Parse(BSal) * 0.4;
        }
        void Marking()
        {

            if (degree == "Professor")
                Mavalue = Double.Parse(BSal) * 1;
            else if (degree == "Assistant professor")
                Mavalue = Double.Parse(BSal) * 0.9;
            else if (degree == "lecturer")
                Mavalue = Double.Parse(BSal) * .7;
            else if (degree == "lecturer assistant")
                Mavalue = Double.Parse(BSal) * 0.5;
            else if (degree == "Demonstrater")
                Mavalue = Double.Parse(BSal) * 0.4;


        }
        void Observe()
        {

            if (degree == "Professor")
                Obsvalue = Double.Parse(BSal) * 1;
            else if (degree == "Assistant professor")
                Obsvalue = Double.Parse(BSal) * 0.9;
            else if (degree == "lecturer")
                Obsvalue = Double.Parse(BSal) * .7;
            else if (degree == "lecturer assistant")
                Obsvalue = Double.Parse(BSal) * 2.5;
            else if (degree == "Demonstrater")
                Obsvalue = Double.Parse(BSal) * 2.4;
        }

        void Research()
        {

            if (degree == "Professor")
                Researchvalue = Double.Parse(BSal) * 1;
            else if (degree == "Assistant professor")
                Researchvalue = Double.Parse(BSal) * 0.9;
            else if (degree == "lecturer")
                Researchvalue = Double.Parse(BSal) * .7;
            else if (degree == "lecturer assistant")
                Researchvalue = Double.Parse(BSal) * 0.5;
            else if (degree == "Demonstrater")
                Researchvalue = Double.Parse(BSal) * 0.4;
        }
        void Traffic()
        {

            if (degree == "Professor")
                Trafficvalue = Double.Parse(BSal) * 1;
            else if (degree == "Assistant professor")
                Trafficvalue = Double.Parse(BSal) * 0.9;
            else if (degree == "lecturer")
                Trafficvalue = Double.Parse(BSal) * .7;
            else if (degree == "lecturer assistant")
                Trafficvalue = Double.Parse(BSal) * 0.5;
            else if (degree == "Demonstrater")
                Trafficvalue = Double.Parse(BSal) * 0.4;
        }
        void Accommodation()
        {

            if (degree == "Professor")
                Accommodationvalue = Double.Parse(BSal) * 1;
            else if (degree == "Assistant professor")
                Accommodationvalue = Double.Parse(BSal) * 0.9;
            else if (degree == "lecturer")
                Accommodationvalue = Double.Parse(BSal) * .7;
            else if (degree == "lecturer assistant")
                Accommodationvalue = Double.Parse(BSal) * 0.5;
            else if (degree == "Demonstrater")
                Accommodationvalue = Double.Parse(BSal) * 0.4;
        }
        void Supervisory()
        {

            if (degree == "Professor")
                Supervisoryvalue = Double.Parse(BSal) * 1;
            else if (degree == "Assistant professor")
                Supervisoryvalue = Double.Parse(BSal) * 0.9;
            else if (degree == "lecturer")
                Supervisoryvalue = Double.Parse(BSal) * .7;
            else if (degree == "lecturer assistant")
                Supervisoryvalue = Double.Parse(BSal) * 0.5;
            else if (degree == "Demonstrater")
                Supervisoryvalue = Double.Parse(BSal) * 0.4;
        }

        String nname, degree, dept, Email, sn, BSal, NSal, cbProfition, MyMail = "projectsalary4444@gmail.com", pwd = "Psalaryproject4444";
        double Obsvalue, Mavalue, Overvalue, Controlevalue, Depuvalue, Summervalue, Researchvalue, Supervisoryvalue, Accommodationvalue, Trafficvalue;



        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5APU4L4;Initial Catalog=project;Integrated Security=true");
        SqlDataAdapter Da1;
        SqlDataAdapter Da2;
        SqlCommand cmd = new SqlCommand();



        DataTable Ds1 = new DataTable();
        DataTable Ds2 = new DataTable();
        DataTable Ds3 = new DataTable();
        public Form2()
        {

            InitializeComponent();

            cb_profision.Items.Add("Professor");
            cb_profision.Items.Add("Assistant professor");
            cb_profision.Items.Add("lecturer");
            cb_profision.Items.Add("lecturer assistant");
            cb_profision.Items.Add("Demonstrater");

            cb_department.Items.Add("Math");
            cb_department.Items.Add("Biology");
            cb_department.Items.Add("Potany");
            cb_department.Items.Add("Geology");
            cb_department.Items.Add("Chemistry");

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Form1.admin == "Admin")
                menuStrip.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            but_save.Text = "...";
            but_save.Enabled = false;
            double total;
            if (cb_summer_course.Checked)

                Summer();

            if (cb_deputation.Checked)

                Depu();

            if (cb_exams_control.Checked)

                Controle();

            if (cb_over_time.Checked)

                Over();

            if (cb_exams_marking.Checked)

                Marking();

            if (cb_exams_observation.Checked)

                Observe();

            if (cb_accomodation.Checked)

                Accommodation();

            if (cb_traffic.Checked)

                Traffic();

            if (cb_research.Checked)

                Research();

            if (cb_supervisory.Checked)

                Supervisory();



            total = Summervalue + Controlevalue + Mavalue + Depuvalue + Overvalue + Trafficvalue + Accommodationvalue + Supervisoryvalue + Researchvalue + Obsvalue;

            con.Close();
            cmd.Parameters.Clear();
            cmd.CommandText = "insert into records(Name ,degree ,Department ,email ,SSN ,basesalary ,netsalary ,summercourse ,ExamsControl ,Deputation ,ExamsMarking ,ExamsObservation ,OverTime ,DateAssigned,TrafficAllowance,AccommodationAllowance,SupervisoryBonus,ResearchBonus) values(@nname,@degree,@dept,@Email,@sn,@BSal,@NSal,@Summervalue,@Controlevalue,@Depuvalue,@Mavalue,@Obsvalue,@Overvalue,CONVERT(datetime,'" + System.DateTime.Today.ToString() + "'),@Traffic,@Accommodation,@Supervisory,@Research)";
            cmd.Parameters.AddWithValue("@nname", nname);
            cmd.Parameters.AddWithValue("@degree", degree);
            cmd.Parameters.AddWithValue("@dept", dept);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@sn", sn);
            cmd.Parameters.AddWithValue("@BSal", BSal);
            cmd.Parameters.AddWithValue("@NSal", NSal);
            cmd.Parameters.AddWithValue("@Summervalue", Summervalue);
            cmd.Parameters.AddWithValue("@Controlevalue", Controlevalue);
            cmd.Parameters.AddWithValue("@Depuvalue", Depuvalue);
            cmd.Parameters.AddWithValue("@Mavalue", Mavalue);
            cmd.Parameters.AddWithValue("@Obsvalue", Obsvalue);
            cmd.Parameters.AddWithValue("@Overvalue", Overvalue);
            cmd.Parameters.AddWithValue("@Traffic", Trafficvalue);
            cmd.Parameters.AddWithValue("@Accommodation", Accommodationvalue);
            cmd.Parameters.AddWithValue("@Supervisory", Supervisoryvalue);
            cmd.Parameters.AddWithValue("@Research", Researchvalue);
            cmd.Connection = con;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                con.Close();

            }
            catch { }

            /////////////////////////////////////////////////////////////
            ///////////////////////Sending Emails////////////////////////
            /////////////////////////////////////////////////////////////

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress(MyMail);
                mail.To.Add(Email);
                mail.Subject = "Test Mail";
                mail.IsBodyHtml = true;
                string htmlString = @"<html>" +
                                                "<head>" +
                                                "<style>table{border: 1px solid black;width:40%;}th, td { border: 1px solid black;} span{ font-weight: bold;font-size: 15px;}</style>" +
                                               " </head>" +
                                               " <body>" +
                                                    "<h2>Hello <br><span> &nbsp; &nbsp;" + nname + "</span></h2>" +
                                                    "<p>It is our pleasure to inform you that you just received the following Bonuses.</p>" +
                                                    " <table>" +
                                                       "  <tr>" +
                                                           "<th>Bonus</th>" +
                                                            " <th>Values</th>" +
                                                        " </tr>" +
                                                        " <tr>" +
                                                            " <td>Summer Course</td>" +
                                                            " <td> " + Summervalue + " LE </td>" +
                                                        " </tr>" +
                                                        " <tr>" +
                                                            " <td>Exams control</td>" +
                                                            " <td>" + Controlevalue + " LE </td>" +
                                                        " </tr>" +
                                                        " <tr>" +
                                                            " <td>Exams marking</td>" +
                                                           "  <td>" + Mavalue + " LE </td>" +
                                                            "  </tr>" +
                                                       "  <tr>" +
                                                            " <td>Deputation</td>" +
                                                           "  <td>" + Depuvalue + " LE </td>" +
                                                       "  </tr>" +
                                                        " <tr>" +
                                                            "<td>Over time</td>" +
                                                            "<td>" + Overvalue + " LE </td>" +
                                                        "</tr>" +
                                                        "<tr>" +
                                                            "<td>Traffic allowance</td>" +
                                                            "<td>" + Trafficvalue + " LE </td>" +
                                                        "</tr>" +
                                                        "<tr>" +
                                                         "   <td>Accommodation allowance</td>" +
                                                          "  <td>" + Accommodationvalue + " LE </td>" +
                                                        "</tr>" +
                                                        "<tr>" +
                                                            "<td>Supervisory bonus</td>" +
                                                            "<td>" + Supervisoryvalue + " LE </td>" +
                                                        "</tr>" +
                                                        "<tr>" +
                                                           " <td>Research Bonus</td>" +
                                                            "<td>" + Researchvalue + " LE </td>" +
                                                        "</tr>" +
                                                       " <tr>" +
                                                            "<td>Exams  observation</td>" +
                                                           " <td>" + Obsvalue + " LE </td>" +
                                                        "</tr>" +
                                                         "<tr>" +
                                                            "<th>Total</th>" +
                                                            "<th>" + total + " LE</th> " +
                                                        "</tr>" +
                                                    "</table >" +
                                                "</body>" +
                                                "</html>";


                mail.Body = htmlString;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new
                System.Net.NetworkCredential(MyMail, pwd);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("please select data CORRECTLY !! or check your internet connection");
            }
            /////////////////////////////////////////////////////////////
            /////////////////////////Emails Sent/////////////////////////
            /////////////////////////////////////////////////////////////
            cmd.Parameters.Clear();
            but_save.Text = "Save";
            but_save.Enabled = true;

        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            this.Close();
            fr1.Show();

        }

        private void add_delete_Click(object sender, EventArgs e)
        {
            form_add_delete add_delete = new form_add_delete();
            add_delete.ShowDialog();

        }

        private void modify_Click(object sender, EventArgs e)
        {
            Form_modify modify = new Form_modify();
            modify.ShowDialog();
        }

        private void name_SelectionChangeCommitted(object sender, EventArgs e)
        {

            con.Close();
            Ds1.Clear();
            con.Open();
            Da1 = new SqlDataAdapter("select * from details where name ='" + name.Text.ToString() + "'", con);
            Da1.Fill(Ds1);

            try
            {
                degree = Ds1.Rows[0]["Profision"].ToString();
                dept = Ds1.Rows[0]["Department"].ToString();
                nname = Ds1.Rows[0]["Name"].ToString();
                Email = Ds1.Rows[0]["Email"].ToString();
                sn = Ds1.Rows[0]["SSN"].ToString();
                BSal = Ds1.Rows[0]["BaseSalary"].ToString();
                NSal = Ds1.Rows[0]["NetSalary"].ToString();
            }
            catch { }
            con.Close();
            cb_deputation.Checked = false;
            cb_exams_control.Checked = false;
            cb_exams_marking.Checked = false;
            cb_exams_observation.Checked = false;
            cb_over_time.Checked = false;
            cb_summer_course.Checked = false;
            cb_research.Checked = false;
            cb_traffic.Checked = false;
            cb_accomodation.Checked = false;
            cb_supervisory.Checked = false;
        }

        private void add_user_Click(object sender, EventArgs e)
        {
            form_add_user add_user = new form_add_user();
            add_user.ShowDialog();
        }

        private void change_password_Click(object sender, EventArgs e)
        {
            form_change_password change_password = new form_change_password();
            change_password.ShowDialog();
        }

        private void datahistory_Click(object sender, EventArgs e)
        {

            form_data_history data_history = new form_data_history();
            data_history.ShowDialog();
        }

        private void cb_department_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {

                Ds2.Clear();
                Da1 = new SqlDataAdapter("select name from Details where Details.Profision= '" + cb_profision.SelectedItem.ToString() + "'and details.Department= '" + cb_department.SelectedItem.ToString() + "'", con);
                Da1.Fill(Ds2);
                name.DataSource = Ds2;
                name.DisplayMember = "Name";
                name.SelectedIndex = -1;
            }
            catch { }
        }

        private void cb_profision_SelectionChangeCommitted(object sender, EventArgs e)
        {

            try
            {
                Ds3.Clear();
                Da2 = new SqlDataAdapter("select name from Details where Details.Profision= '" + cb_profision.SelectedItem.ToString() + "'and details.Department= '" + cb_department.SelectedItem.ToString() + "'", con);
                Da2.Fill(Ds3);
                name.DataSource = Ds3;
                name.DisplayMember = "Name";
                name.SelectedIndex = -1;
            }
            catch { }
            cbProfition = cb_profision.SelectedItem.ToString();
        }

    }
}
