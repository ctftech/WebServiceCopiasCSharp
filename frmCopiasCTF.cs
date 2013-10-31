using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;
using TesteCopias.WsCopia;
using System.Diagnostics;
using System.Net;

namespace TesteCopias
{
	/// <summary>
	/// Este aplicativo destina-se unica e exclusivamente de exemplo de como consumir o 
	/// WebService de cópias não tendo a CTF nenhuma obrigação a suporte deste aplicativo.
	/// </summary>
	public class frmCopiasCTF : System.Windows.Forms.Form
	{
		#region Declaracoes

		private System.Windows.Forms.TextBox txtPonteiro;
		private System.Windows.Forms.Label lblPonteiro;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.TextBox txtRegistros;
		private System.Windows.Forms.Label lblQtdRegistros;
		private System.Windows.Forms.Label lblTotalRegistros;
		private System.Windows.Forms.Button btnListarTemplatesDisponiveis;
		private System.Windows.Forms.ListBox lstTemplatesDisponiveis;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSalvarDados;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtUsuarioDominio;
		private System.Windows.Forms.TextBox txtSenhaDominio;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private string ret;
		private System.Windows.Forms.TextBox txtPorta;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDominio;
		private System.Windows.Forms.TextBox txtEndereco;
		#endregion

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		[STAThread]
		static void Main() 
		{
			Application.Run(new frmCopiasCTF());
			
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.txtRegistros = new System.Windows.Forms.TextBox();
			this.lblQtdRegistros = new System.Windows.Forms.Label();
			this.txtPonteiro = new System.Windows.Forms.TextBox();
			this.lblPonteiro = new System.Windows.Forms.Label();
			this.lblTotalRegistros = new System.Windows.Forms.Label();
			this.btnListarTemplatesDisponiveis = new System.Windows.Forms.Button();
			this.lstTemplatesDisponiveis = new System.Windows.Forms.ListBox();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSalvarDados = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtDominio = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPorta = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtEndereco = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSenhaDominio = new System.Windows.Forms.TextBox();
			this.txtUsuarioDominio = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.lblSenha = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPesquisar.Location = new System.Drawing.Point(8, 152);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(360, 23);
			this.btnPesquisar.TabIndex = 4;
			this.btnPesquisar.Text = "&Pesquisar";
			this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
			// 
			// txtRegistros
			// 
			this.txtRegistros.Location = new System.Drawing.Point(208, 120);
			this.txtRegistros.Name = "txtRegistros";
			this.txtRegistros.Size = new System.Drawing.Size(48, 20);
			this.txtRegistros.TabIndex = 11;
			this.txtRegistros.Text = "8000";
			// 
			// lblQtdRegistros
			// 
			this.lblQtdRegistros.Location = new System.Drawing.Point(128, 128);
			this.lblQtdRegistros.Name = "lblQtdRegistros";
			this.lblQtdRegistros.Size = new System.Drawing.Size(80, 16);
			this.lblQtdRegistros.TabIndex = 10;
			this.lblQtdRegistros.Text = "Qtd Registros:";
			// 
			// txtPonteiro
			// 
			this.txtPonteiro.Location = new System.Drawing.Point(64, 120);
			this.txtPonteiro.Name = "txtPonteiro";
			this.txtPonteiro.Size = new System.Drawing.Size(48, 20);
			this.txtPonteiro.TabIndex = 9;
			this.txtPonteiro.Text = "0";
			// 
			// lblPonteiro
			// 
			this.lblPonteiro.Location = new System.Drawing.Point(8, 128);
			this.lblPonteiro.Name = "lblPonteiro";
			this.lblPonteiro.Size = new System.Drawing.Size(64, 16);
			this.lblPonteiro.TabIndex = 8;
			this.lblPonteiro.Text = "Ponteiro:";
			// 
			// lblTotalRegistros
			// 
			this.lblTotalRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lblTotalRegistros.Location = new System.Drawing.Point(16, 632);
			this.lblTotalRegistros.Name = "lblTotalRegistros";
			this.lblTotalRegistros.Size = new System.Drawing.Size(80, 16);
			this.lblTotalRegistros.TabIndex = 9;
			// 
			// btnListarTemplatesDisponiveis
			// 
			this.btnListarTemplatesDisponiveis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.btnListarTemplatesDisponiveis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnListarTemplatesDisponiveis.Location = new System.Drawing.Point(8, 24);
			this.btnListarTemplatesDisponiveis.Name = "btnListarTemplatesDisponiveis";
			this.btnListarTemplatesDisponiveis.Size = new System.Drawing.Size(360, 24);
			this.btnListarTemplatesDisponiveis.TabIndex = 2;
			this.btnListarTemplatesDisponiveis.Text = "Listar Templates Disponiveis";
			this.btnListarTemplatesDisponiveis.Click += new System.EventHandler(this.btnListarTemplatesDisponiveis_Click);
			// 
			// lstTemplatesDisponiveis
			// 
			this.lstTemplatesDisponiveis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lstTemplatesDisponiveis.Location = new System.Drawing.Point(8, 56);
			this.lstTemplatesDisponiveis.Name = "lstTemplatesDisponiveis";
			this.lstTemplatesDisponiveis.Size = new System.Drawing.Size(360, 56);
			this.lstTemplatesDisponiveis.TabIndex = 3;
			// 
			// dataGrid1
			// 
			this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(16, 432);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(384, 160);
			this.dataGrid1.TabIndex = 12;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.lstTemplatesDisponiveis);
			this.groupBox1.Controls.Add(this.btnListarTemplatesDisponiveis);
			this.groupBox1.Controls.Add(this.txtRegistros);
			this.groupBox1.Controls.Add(this.btnPesquisar);
			this.groupBox1.Controls.Add(this.lblQtdRegistros);
			this.groupBox1.Controls.Add(this.txtPonteiro);
			this.groupBox1.Controls.Add(this.lblPonteiro);
			this.groupBox1.Location = new System.Drawing.Point(16, 216);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(384, 192);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Templates Disponiveis";
			// 
			// btnSalvarDados
			// 
			this.btnSalvarDados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSalvarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalvarDados.Location = new System.Drawing.Point(16, 600);
			this.btnSalvarDados.Name = "btnSalvarDados";
			this.btnSalvarDados.Size = new System.Drawing.Size(120, 23);
			this.btnSalvarDados.TabIndex = 14;
			this.btnSalvarDados.Text = "Salvar Dados";
			this.btnSalvarDados.Click += new System.EventHandler(this.btnSalvarDados_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "Arquivos XML(*.xml)|*.xml";
			this.saveFileDialog1.Title = "Salvar XML";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.txtDominio);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.txtPorta);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.txtEndereco);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtSenhaDominio);
			this.groupBox2.Controls.Add(this.txtUsuarioDominio);
			this.groupBox2.Location = new System.Drawing.Point(16, 24);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(384, 120);
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Proxy";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 96);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 11;
			this.label1.Text = "Dominio:";
			// 
			// txtDominio
			// 
			this.txtDominio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtDominio.Location = new System.Drawing.Point(128, 88);
			this.txtDominio.Name = "txtDominio";
			this.txtDominio.Size = new System.Drawing.Size(240, 20);
			this.txtDominio.TabIndex = 10;
			this.txtDominio.Text = "";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.Location = new System.Drawing.Point(259, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 16);
			this.label5.TabIndex = 9;
			this.label5.Text = "Porta:";
			// 
			// txtPorta
			// 
			this.txtPorta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPorta.Location = new System.Drawing.Point(296, 16);
			this.txtPorta.Name = "txtPorta";
			this.txtPorta.Size = new System.Drawing.Size(72, 20);
			this.txtPorta.TabIndex = 8;
			this.txtPorta.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 16);
			this.label4.TabIndex = 7;
			this.label4.Text = "Endereço:";
			// 
			// txtEndereco
			// 
			this.txtEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtEndereco.Location = new System.Drawing.Point(128, 16);
			this.txtEndereco.Name = "txtEndereco";
			this.txtEndereco.Size = new System.Drawing.Size(120, 20);
			this.txtEndereco.TabIndex = 6;
			this.txtEndereco.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Senha:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Usuário:";
			// 
			// txtSenhaDominio
			// 
			this.txtSenhaDominio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtSenhaDominio.Location = new System.Drawing.Point(128, 64);
			this.txtSenhaDominio.Name = "txtSenhaDominio";
			this.txtSenhaDominio.PasswordChar = '*';
			this.txtSenhaDominio.Size = new System.Drawing.Size(240, 20);
			this.txtSenhaDominio.TabIndex = 2;
			this.txtSenhaDominio.Text = "";
			// 
			// txtUsuarioDominio
			// 
			this.txtUsuarioDominio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtUsuarioDominio.Location = new System.Drawing.Point(128, 40);
			this.txtUsuarioDominio.Name = "txtUsuarioDominio";
			this.txtUsuarioDominio.Size = new System.Drawing.Size(240, 20);
			this.txtUsuarioDominio.TabIndex = 1;
			this.txtUsuarioDominio.Text = "";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtSenha);
			this.groupBox3.Controls.Add(this.txtUsuario);
			this.groupBox3.Controls.Add(this.lblSenha);
			this.groupBox3.Controls.Add(this.lblUsuario);
			this.groupBox3.Location = new System.Drawing.Point(16, 152);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(384, 56);
			this.groupBox3.TabIndex = 16;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Autenticacao Web Service";
			// 
			// txtSenha
			// 
			this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSenha.Location = new System.Drawing.Point(248, 24);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(112, 20);
			this.txtSenha.TabIndex = 8;
			this.txtSenha.Text = "";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(56, 24);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(144, 20);
			this.txtUsuario.TabIndex = 7;
			this.txtUsuario.Text = "";
			// 
			// lblSenha
			// 
			this.lblSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSenha.Location = new System.Drawing.Point(208, 32);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(48, 16);
			this.lblSenha.TabIndex = 10;
			this.lblSenha.Text = "Senha:";
			// 
			// lblUsuario
			// 
			this.lblUsuario.Location = new System.Drawing.Point(8, 32);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(48, 16);
			this.lblUsuario.TabIndex = 9;
			this.lblUsuario.Text = "Usuário:";
			// 
			// frmCopiasCTF
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(416, 670);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnSalvarDados);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.lblTotalRegistros);
			this.Name = "frmCopiasCTF";
			this.Text = "Cópias CTF - Technologies do Brasil";
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Eventos

		public frmCopiasCTF()
		{
			InitializeComponent();
			CarregarCampos();
		}


		private void btnPesquisar_Click(object sender, System.EventArgs e)
		{
			try
			{

				if(lstTemplatesDisponiveis.SelectedValue == null)
				{
					MessageBox.Show("Selecione um template !");
					return;
				}


				/* Realizamos a chamada ao método que realizará a chamada ao WebService
				 * e retornara os dados em XML
				 */
				ret = RecuperarDadosCopia();

				/* Instancimaos um objeto DataSet para carregá-lo com o XML obtido do retorno
				 * do WebService
				 */
				DataSet ds = new DataSet();

				
				// Realiza a carga do DataSet com o XML obtido.
				ds.ReadXml(new System.IO.StringReader(ret), XmlReadMode.InferSchema);

				// Atribuimos o dataSet ao DataGrid
				dataGrid1.DataSource = ds.Tables[0];

				lblTotalRegistros.Text = "Foram retornados " + ds.Tables[0].Rows.Count + " registros.";
			}
			catch(System.Web.Services.Protocols.SoapException ex)
			{
				string errMsg =	string.Format("Erro:\r\nCódigo: {0} \r\nDescrição: {1}", 
					ex.Detail["Error"]["ErrorNumber"].InnerText,
					ex.Detail["Error"]["ErrorMessage"].InnerText);
				MessageBox.Show(errMsg);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
	
		private void btnListarTemplatesDisponiveis_Click(object sender, System.EventArgs e)
		{
			try
			{
				ret = RecuperarTemplatesDisponiveis();


				// Instanciamos um DataSet para carregá-lo com o XML obtido
				DataSet ds = new DataSet();

				// Realizamos a carga do dataset com o XML
				ds.ReadXml(new System.IO.StringReader(ret), XmlReadMode.InferSchema);

				// Preechemos o ListBox com os dados carregados do DataSet
				lstTemplatesDisponiveis.ValueMember = "CodigoTemplate";
				lstTemplatesDisponiveis.DisplayMember = "DescricaoTemplate";
				lstTemplatesDisponiveis.DataSource = ds.Tables[0];
			}
			catch(System.Web.Services.Protocols.SoapException ex)
			{
				string errMsg =	string.Format("Erro:\r\nCódigo: {0} \r\nDescrição: {1}", 
					ex.Detail["Error"]["ErrorNumber"].InnerText,
					ex.Detail["Error"]["ErrorMessage"].InnerText);
				MessageBox.Show(errMsg);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnSalvarDados_Click(object sender, System.EventArgs e)
		{
			if(ret != null && ret.Trim() != string.Empty)
			{
				saveFileDialog1.ShowDialog();

				string file = saveFileDialog1.FileName;

				using(System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(file))
				{
					streamWriter.Write(ret);
					streamWriter.Close();
				}
			}
			else
			{
				MessageBox.Show("Não há dados para serem gravados");
			}
		}

		
		#endregion

		#region Metodos

		/// <summary>
		/// Carrega os campos de configuração do proxy caso haja alguma configuração
		/// pré estabelecida no Internet Explorer
		/// </summary>
		private void CarregarCampos()
		{
			Uri uri = System.Net.WebProxy.GetDefaultProxy().Address;
			if(uri != null)
			{
				txtEndereco.Text = uri.Host;
				txtPorta.Text = uri.Port.ToString();
				txtUsuarioDominio.Text = uri.UserInfo;
			}
		}

		/// <summary>
		/// Cria a instancia do proxy do WebService
		/// </summary>
		/// <returns></returns>
		private WsCopia.WsCopia CreateWsCopia()
		{
			// Instanciamos o client do WebService
			WsCopia.WsCopia wsCopia = new WsCopia.WsCopia();

			// Caso o proxy for configurado
			if(txtEndereco.Text.Trim() != string.Empty &&
				txtPorta.Text.Trim() != string.Empty &&
				txtSenhaDominio.Text.Trim() != string.Empty &&
				txtUsuarioDominio.Text.Trim() != string.Empty)
			{
				NetworkCredential credential = new NetworkCredential();
				credential.Domain = txtDominio.Text.Trim();
				credential.Password = txtSenhaDominio.Text.Trim();
				credential.UserName = txtUsuarioDominio.Text.Trim();

				WebProxy proxy = 
					new WebProxy(string.Format("{0}:{1}", txtEndereco.Text.Trim(), txtPorta.Text.Trim()));
				proxy.Credentials = credential;

				wsCopia.Proxy = proxy;
				
				// Aumentamos o timeout, visto que a chamada pode ser demorada
				wsCopia.Timeout = 1000000;		
			}
			return wsCopia;
		}



		/// <summary>
		/// Método que realiza o login e efetua a recuperação dos registros da cópia conforme template escolhido
		/// </summary>
		/// <returns></returns>
		private string RecuperarDadosCopia()
		{
			WsCopia.WsCopia wsCopia = CreateWsCopia();
			// Instanciação e atribuição do Objeto Login
			SoapLogin login = new SoapLogin();
			login.login = txtUsuario.Text;		// Login fornecido pela CTF
			login.senha = txtSenha.Text;		// Senha fornecida pela CTF

			// Atribuição do Objeto Login no Proxy
			wsCopia.SoapLoginValue = login;

			// Instanciamos o Objeto ParametroCopia que é nosso transporte de dados
			ParametrosCopia parametrosCopia = new ParametrosCopia();


			/* Atribuimos o código do template desejado, tal código foi obtido à partir da
			 * chamada do WebMethod "ListarTemplatesDisponiveis"
			 */
			parametrosCopia.CodTemplate = int.Parse(lstTemplatesDisponiveis.SelectedValue.ToString());//int.Parse(txtCodCopia.Text);
			
			
			/* Atribuimos o valor do ponteiro caso este seja necessário, podemos saber se ele é 
			 * requerido pelo retorno da chamada do WebMethod "ListarTemplatesDisponiveis" cujo campo
			 * "UtilizaPonteiro" estiver marcado como "true"
			 */
			parametrosCopia.Ponteiro = int.Parse(txtPonteiro.Text);
			
			
			/* Atribuimos a quantidade de registros à serem retornados. (Este parâmetro só deve ser utilizado,
			 * caso o template desejado utilize ponteiro ou seja o campo "UtilizaPonteiro" do WebMethod 
			 * "ListarTemplatesDisponiveis" estiver marcado como "true"
			 */
			parametrosCopia.QtdRegistro = int.Parse(txtRegistros.Text);

			/* Realizamos a chamada ao WebMethod RecuperarCopia passando como parâmetro o objeto 
			 * "parametrosCopia" instanciado e com os valores atribuidos anteriormente.
			 */
			DateTime inicio = DateTime.Now;
			string ret = wsCopia.RecuperarCopia(parametrosCopia);

			return ret;
		}


		/// <summary>
		/// Recupera todos os Templates de Cópias disponiveis para a Empresa.
		/// </summary>
		/// <returns>XML contendo: CodigoTemplate, DescricaoTemplate, UtilizaPonteiro</returns>
		private string RecuperarTemplatesDisponiveis()
		{
			WsCopia.WsCopia wsCopia = CreateWsCopia();

			// Instanciação e atribuição do Objeto Login
			SoapLogin login = new SoapLogin();
			login.login = txtUsuario.Text;		// Login fornecido pela CTF
			login.senha = txtSenha.Text;		// Senha fornecida pela CTF

			// Atribuição do Objeto Login no Proxy
			wsCopia.SoapLoginValue = login;


			/* Realiza a chamada ao Método ListarTemplatesDisponiveis do WebService obtendo o
			 * retorno do xml com os dados no formato:
			 * <Templates>
			 *		<Template>
			 *			<CodigoTemplate />
			 *			<DescricaoTemplate />
			 *			<UtilizaPonteiro />
			 *		<Template>
			 * </Templates>
			 */
			string ret = wsCopia.ListarTemplatesDisponiveis();
			return ret;
		}

		#endregion

	}
}
