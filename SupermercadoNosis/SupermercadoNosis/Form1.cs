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
using System.Configuration;
using Microsoft.VisualBasic;

namespace SupermercadoNosis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataLoad();
        }

        private void dataLoad()
        {
            try
            {
                var db = new dbClass();
                String query = "select c.IdCaja as Caja, sum(case when p.Estado=1 then 1 else 0 end) as Atender, sum(case when p.Estado=0 then 1 else 0 end) as Atendidos  from Caja c left join CajaXCliente p on c.IdCaja=p.IdCaja where c.Estado=1 group by c.IdCaja";
                var ds = db.ExecuteQuery(query);
                if (ds.Tables.Count > 0)
                {
                    dt_Cajas.DataSource = ds.Tables[0];
                    dt_Cajas.Show();
                }
            }catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void btn_AbrirCaja_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new dbClass();
                String query = "insert into Caja (Estado) values (1);";
                var ds = db.ExecuteQuery(query);
                dataLoad();
                MessageBox.Show("Se Abrio una nueva Caja");
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void btn_CerrarCaja_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dt_Cajas.Rows[dt_Cajas.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                var db = new dbClass();
                String query = "select p.IdCliente from CajaXCliente p where p.IdCaja=" + id + " and p.Estado=1;";
                var ds = db.ExecuteQuery(query);
                DataTable table = ds.Tables[0];
                query = "update Caja set Estado = 0 where IdCaja = " + id + ";";
                ds = db.ExecuteQuery(query);
                query = "select t.Caja Caja,  min(t.cliCount) as mini from (select c.IdCaja as Caja, sum(case when p.Estado=1 then 1 else 0 end) as cliCount from Caja c left join CajaXCliente p on c.IdCaja=p.IdCaja where c.Estado=1 group by c.IdCaja) t group by Caja order by mini asc";
                ds = db.ExecuteQuery(query);
                var idC = ds.Tables[0].Rows[0].ItemArray[0];
                foreach (DataRow row in table.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        query = "insert into CajaXCliente(IdCaja,IdCliente,Estado) values(" + idC + "," + item + ",1)";
                        ds = db.ExecuteQuery(query);
                    }
                }
                dataLoad();
                MessageBox.Show("Se cerro la Caja "+ id);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {

                string input = Interaction.InputBox("Nombre del Cliente", "Agregar Cliente", "", -1, -1);
                if (!String.IsNullOrEmpty(input))
                {
                    var db = new dbClass();
                    String query = "insert into Cliente (Nombre,Estado) output inserted.IdCliente values('" + input + "',1);";
                    var ds = db.ExecuteQuery(query);
                    var id = ds.Tables[0].Rows[0].ItemArray[0];
                    query = "select t.Caja Caja,  min(t.cliCount) as mini from (select c.IdCaja as Caja, sum(case when p.Estado=1 then 1 else 0 end) as cliCount from Caja c left join CajaXCliente p on c.IdCaja=p.IdCaja where c.Estado=1 group by c.IdCaja) t group by Caja order by mini asc";
                    ds = db.ExecuteQuery(query);
                    var idC = ds.Tables[0].Rows[0].ItemArray[0];
                    query = "insert into CajaXCliente(IdCaja,IdCliente,Estado) values(" + idC + "," + id + ",1)";
                    ds = db.ExecuteQuery(query);
                    dataLoad();
                    MessageBox.Show("Se agrego el cliente "+ input);
                }                
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void btn_AtenderCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dt_Cajas.Rows[dt_Cajas.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                var db = new dbClass();
                String query = "select p.IdCliente from CajaXCliente p where p.IdCaja=" + id + " and p.Estado=1;";
                var ds = db.ExecuteQuery(query);
                var idC = ds.Tables[0].Rows[0].ItemArray[0];
                query = "update CajaXCliente set Estado=0 where IdCaja=" + id + " and IdCliente=" + idC + ";";
                ds = db.ExecuteQuery(query);
                dataLoad();
                MessageBox.Show("Cliente atendido.");
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            
        }
    }
}
