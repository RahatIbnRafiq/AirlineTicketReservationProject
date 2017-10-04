using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bank
{
    public partial class Loan_Opening_Form : Form
    {
        public OracleConnect oc;
        public ParamClass[] pm, pout;
        public bool flag;

	  public OracleConnect(string database, string username, String password)
        {
            try
            {
                this.connectionString = "User id=" + username + ";Password=" + password + ";Data Source=" + database;
                this.connection = new System.Data.OracleClient.OracleConnection(this.connectionString);
                this.connection.Open();
                this.command = connection.CreateCommand();
                MessageBox.Show("Connecting to Oracle Database has been successfully completed.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error while connecting :" + e.Message);
            }

        }

	  public void callProcedure(string name,ParamClass []pmIn,ParamClass []pmOut)
        {
            this.command.CommandType = CommandType.StoredProcedure;
            this.command.CommandText = name;
            
            int countIn = pmIn.Length;
            int countOut = pmOut.Length;
            OracleParameter[] op = new OracleParameter[countIn];

            for (int i = 0; i < countIn; i++)
            {  
                if (pmIn[i].Type.Equals("varchar2"))
                {
                    op[i] = new OracleParameter(pmIn[i].Param_name, OracleType.VarChar);
                    op[i].Value = pmIn[i].Value;
                }
                else if (pmIn[i].Type.Equals("number"))
                {
                    op[i] = new OracleParameter(pmIn[i].Param_name, OracleType.Number);
                    op[i].Value = Int32.Parse(pmIn[i].Value);
                }
                op[i].Direction = ParameterDirection.Input;
                this.command.Parameters.Add(op[i]);
            }
            OracleParameter[] opOut = new OracleParameter[countOut];
            for (int i = 0; i < countOut; i++)
            {

                if (pmOut[i].Type.Equals("varchar2"))
                {
                    opOut[i] = new OracleParameter(pmOut[i].Param_name, OracleType.VarChar);
                    

                }
                else if (pmOut[i].Type.Equals("number"))
                {
                    opOut[i] = new OracleParameter(pmOut[i].Param_name, OracleType.Number);
                }
                opOut[i].Direction = ParameterDirection.Output;
                this.command.Parameters.Add(opOut[i]);
            }

            this.command.ExecuteNonQuery();
            for (int i = 0; i < countOut; i++)
            {
                pmOut[i].Value = opOut[i].Value.ToString();
            }
        
            for (int i = 0; i < countIn; i++)
            {
                this.command.Parameters.Remove(op[i]);
            }
            for (int i = 0; i < countOut; i++)
            {
                this.command.Parameters.Remove(opOut[i]);
            }
          //  MessageBox.Show(opOut[0].Value.ToString());
         
        }

        private void CLbutton_Click(object sender, EventArgs e)
        {
            try
            {
                pm = new ParamClass[6];
                pout = new ParamClass[1];
                pm[0] = new ParamClass("acc_id", "varchar2", ADtextBox.Text);
                pm[1] = new ParamClass("loan_type", "varchar2", lycomboBox.Text);
                pm[2] = new ParamClass("amount", "number", AmounttextBox.Text);
                pm[3] = new ParamClass("ins_no", "number", incomboBox.Text);
                pm[4] = new ParamClass("loan_id", "varchar2", LoanIdtextBox.Text);
                pm[5] = new ParamClass("duration", "number", durcomboBox.Text);
                pout[0] = new ParamClass("ret_val", "number", "");
                this.callProcedure("new_loan_insert", pm, pout);
            }
            catch (Exception r1)
            {
                MessageBox.Show("Error : " + r1);
            }

        }   
       
    }
}