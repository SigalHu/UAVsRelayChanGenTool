namespace UAVsRelayChanGenTool
{
    partial class ChanGenTool
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChanGenTool));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.当前页面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.载入配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.当前页面ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.输出配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.输出路径ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.输出覆盖ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信道仿真ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配置硬件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启动设备ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.画图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收发端轨迹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.天线增益ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发射端ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.接收端ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于软件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolMenu = new System.Windows.Forms.ToolStrip();
            this.btnSaveCfg = new System.Windows.Forms.ToolStripButton();
            this.btnLoadCfg = new System.Windows.Forms.ToolStripButton();
            this.btnOutputSet = new System.Windows.Forms.ToolStripButton();
            this.btnOutputCover = new System.Windows.Forms.ToolStripButton();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnChanGen = new System.Windows.Forms.ToolStripButton();
            this.btnCfgFPGA = new System.Windows.Forms.ToolStripButton();
            this.btnRunFPGA = new System.Windows.Forms.ToolStripButton();
            this.btnChanFig = new System.Windows.Forms.ToolStripButton();
            this.grpSystemPara = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAeroCarrierFre = new System.Windows.Forms.TextBox();
            this.lalAeroCarrierFre = new System.Windows.Forms.Label();
            this.cboSampleFre = new System.Windows.Forms.ComboBox();
            this.cboCarrierFre = new System.Windows.Forms.ComboBox();
            this.cboG2AEnv = new System.Windows.Forms.ComboBox();
            this.lalAeroUpdateUnit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAeroUpdate = new System.Windows.Forms.TextBox();
            this.lalAeroUpdate = new System.Windows.Forms.Label();
            this.statusShow = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lalOutputPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDateNow = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpLaun = new System.Windows.Forms.GroupBox();
            this.grpLaunPos = new System.Windows.Forms.GroupBox();
            this.lalLaunPosXUnit = new System.Windows.Forms.Label();
            this.txtLaunPosX = new System.Windows.Forms.TextBox();
            this.lalLaunPosX = new System.Windows.Forms.Label();
            this.lalLaunPosYUnit = new System.Windows.Forms.Label();
            this.txtLaunPosY = new System.Windows.Forms.TextBox();
            this.lalLaunPosY = new System.Windows.Forms.Label();
            this.grpLaunSpeed = new System.Windows.Forms.GroupBox();
            this.lalLaunSpeedXUnit = new System.Windows.Forms.Label();
            this.txtLaunSpeedX = new System.Windows.Forms.TextBox();
            this.lalLaunSpeedX = new System.Windows.Forms.Label();
            this.lalLaunSpeedYUnit = new System.Windows.Forms.Label();
            this.txtLaunSpeedY = new System.Windows.Forms.TextBox();
            this.lalLaunSpeedY = new System.Windows.Forms.Label();
            this.lalLaunAnte = new System.Windows.Forms.Label();
            this.btnLaunAnte = new System.Windows.Forms.Button();
            this.txtLaunAnte = new System.Windows.Forms.TextBox();
            this.chtRelayNet = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpRelay = new System.Windows.Forms.GroupBox();
            this.lalCoverAreaUnit = new System.Windows.Forms.Label();
            this.txtCoverArea = new System.Windows.Forms.TextBox();
            this.lalCoverArea = new System.Windows.Forms.Label();
            this.lalAFGainUnit = new System.Windows.Forms.Label();
            this.txtAFGain = new System.Windows.Forms.TextBox();
            this.lalAFGain = new System.Windows.Forms.Label();
            this.lalFlightHeightUnit = new System.Windows.Forms.Label();
            this.txtFlightHeight = new System.Windows.Forms.TextBox();
            this.lalFlightHeight = new System.Windows.Forms.Label();
            this.lalRelayAnte = new System.Windows.Forms.Label();
            this.btnRelayAnte = new System.Windows.Forms.Button();
            this.txtRelayAnte = new System.Windows.Forms.TextBox();
            this.grpRecv = new System.Windows.Forms.GroupBox();
            this.grpRecvPos = new System.Windows.Forms.GroupBox();
            this.lalRecvPosXUnit = new System.Windows.Forms.Label();
            this.txtRecvPosX = new System.Windows.Forms.TextBox();
            this.lalRecvPosX = new System.Windows.Forms.Label();
            this.lalRecvPosYUnit = new System.Windows.Forms.Label();
            this.txtRecvPosY = new System.Windows.Forms.TextBox();
            this.lalRecvPosY = new System.Windows.Forms.Label();
            this.grpRecvSpeed = new System.Windows.Forms.GroupBox();
            this.lalRecvSpeedXUnit = new System.Windows.Forms.Label();
            this.txtRecvSpeedX = new System.Windows.Forms.TextBox();
            this.lalRecvSpeedX = new System.Windows.Forms.Label();
            this.lalRecvSpeedYUnit = new System.Windows.Forms.Label();
            this.txtRecvSpeedY = new System.Windows.Forms.TextBox();
            this.lalRecvSpeedY = new System.Windows.Forms.Label();
            this.lalRecvAnte = new System.Windows.Forms.Label();
            this.btnRecvAnte = new System.Windows.Forms.Button();
            this.txtRecvAnte = new System.Windows.Forms.TextBox();
            this.MainMenu.SuspendLayout();
            this.MainToolMenu.SuspendLayout();
            this.grpSystemPara.SuspendLayout();
            this.statusShow.SuspendLayout();
            this.grpLaun.SuspendLayout();
            this.grpLaunPos.SuspendLayout();
            this.grpLaunSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtRelayNet)).BeginInit();
            this.grpRelay.SuspendLayout();
            this.grpRecv.SuspendLayout();
            this.grpRecvPos.SuspendLayout();
            this.grpRecvSpeed.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.Transparent;
            this.MainMenu.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.画图ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.MainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainMenu.Size = new System.Drawing.Size(969, 27);
            this.MainMenu.TabIndex = 38;
            this.MainMenu.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存配置ToolStripMenuItem,
            this.载入配置ToolStripMenuItem,
            this.输出配置ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 保存配置ToolStripMenuItem
            // 
            this.保存配置ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.保存配置ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.保存配置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全部ToolStripMenuItem,
            this.当前页面ToolStripMenuItem});
            this.保存配置ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.保存配置ToolStripMenuItem.Name = "保存配置ToolStripMenuItem";
            this.保存配置ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.保存配置ToolStripMenuItem.Text = "保存配置";
            // 
            // 全部ToolStripMenuItem
            // 
            this.全部ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.全部ToolStripMenuItem.Name = "全部ToolStripMenuItem";
            this.全部ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.全部ToolStripMenuItem.Text = "全部";
            // 
            // 当前页面ToolStripMenuItem
            // 
            this.当前页面ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.当前页面ToolStripMenuItem.Name = "当前页面ToolStripMenuItem";
            this.当前页面ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.当前页面ToolStripMenuItem.Text = "当前页面";
            // 
            // 载入配置ToolStripMenuItem
            // 
            this.载入配置ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.载入配置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全部ToolStripMenuItem1,
            this.当前页面ToolStripMenuItem1});
            this.载入配置ToolStripMenuItem.Name = "载入配置ToolStripMenuItem";
            this.载入配置ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.载入配置ToolStripMenuItem.Text = "载入配置";
            // 
            // 全部ToolStripMenuItem1
            // 
            this.全部ToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.全部ToolStripMenuItem1.Name = "全部ToolStripMenuItem1";
            this.全部ToolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.全部ToolStripMenuItem1.Text = "全部";
            // 
            // 当前页面ToolStripMenuItem1
            // 
            this.当前页面ToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.当前页面ToolStripMenuItem1.Name = "当前页面ToolStripMenuItem1";
            this.当前页面ToolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.当前页面ToolStripMenuItem1.Text = "当前页面";
            // 
            // 输出配置ToolStripMenuItem
            // 
            this.输出配置ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.输出配置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.输出路径ToolStripMenuItem,
            this.输出覆盖ToolStripMenuItem});
            this.输出配置ToolStripMenuItem.Name = "输出配置ToolStripMenuItem";
            this.输出配置ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.输出配置ToolStripMenuItem.Text = "输出配置";
            // 
            // 输出路径ToolStripMenuItem
            // 
            this.输出路径ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.输出路径ToolStripMenuItem.Name = "输出路径ToolStripMenuItem";
            this.输出路径ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.输出路径ToolStripMenuItem.Text = "输出路径";
            // 
            // 输出覆盖ToolStripMenuItem
            // 
            this.输出覆盖ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.输出覆盖ToolStripMenuItem.Checked = true;
            this.输出覆盖ToolStripMenuItem.CheckOnClick = true;
            this.输出覆盖ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.输出覆盖ToolStripMenuItem.Name = "输出覆盖ToolStripMenuItem";
            this.输出覆盖ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.输出覆盖ToolStripMenuItem.Text = "结果覆盖";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.信道仿真ToolStripMenuItem,
            this.配置硬件ToolStripMenuItem,
            this.启动设备ToolStripMenuItem});
            this.工具ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.工具ToolStripMenuItem.Text = "运行";
            // 
            // 信道仿真ToolStripMenuItem
            // 
            this.信道仿真ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.信道仿真ToolStripMenuItem.Name = "信道仿真ToolStripMenuItem";
            this.信道仿真ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.信道仿真ToolStripMenuItem.Text = "信道仿真";
            // 
            // 配置硬件ToolStripMenuItem
            // 
            this.配置硬件ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.配置硬件ToolStripMenuItem.Name = "配置硬件ToolStripMenuItem";
            this.配置硬件ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.配置硬件ToolStripMenuItem.Text = "配置硬件";
            // 
            // 启动设备ToolStripMenuItem
            // 
            this.启动设备ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.启动设备ToolStripMenuItem.Name = "启动设备ToolStripMenuItem";
            this.启动设备ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.启动设备ToolStripMenuItem.Text = "启动设备";
            // 
            // 画图ToolStripMenuItem
            // 
            this.画图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.收发端轨迹ToolStripMenuItem,
            this.天线增益ToolStripMenuItem});
            this.画图ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.画图ToolStripMenuItem.Name = "画图ToolStripMenuItem";
            this.画图ToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.画图ToolStripMenuItem.Text = "画图";
            // 
            // 收发端轨迹ToolStripMenuItem
            // 
            this.收发端轨迹ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.收发端轨迹ToolStripMenuItem.Name = "收发端轨迹ToolStripMenuItem";
            this.收发端轨迹ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.收发端轨迹ToolStripMenuItem.Text = "收发端轨迹";
            // 
            // 天线增益ToolStripMenuItem
            // 
            this.天线增益ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.天线增益ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.发射端ToolStripMenuItem,
            this.接收端ToolStripMenuItem});
            this.天线增益ToolStripMenuItem.Name = "天线增益ToolStripMenuItem";
            this.天线增益ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.天线增益ToolStripMenuItem.Text = "天线增益";
            // 
            // 发射端ToolStripMenuItem
            // 
            this.发射端ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.发射端ToolStripMenuItem.Name = "发射端ToolStripMenuItem";
            this.发射端ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.发射端ToolStripMenuItem.Text = "发射端";
            // 
            // 接收端ToolStripMenuItem
            // 
            this.接收端ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.接收端ToolStripMenuItem.Name = "接收端ToolStripMenuItem";
            this.接收端ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.接收端ToolStripMenuItem.Text = "接收端";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看帮助ToolStripMenuItem,
            this.关于软件ToolStripMenuItem});
            this.帮助ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 查看帮助ToolStripMenuItem
            // 
            this.查看帮助ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.查看帮助ToolStripMenuItem.Name = "查看帮助ToolStripMenuItem";
            this.查看帮助ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.查看帮助ToolStripMenuItem.Text = "查看帮助";
            // 
            // 关于软件ToolStripMenuItem
            // 
            this.关于软件ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.关于软件ToolStripMenuItem.Name = "关于软件ToolStripMenuItem";
            this.关于软件ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.关于软件ToolStripMenuItem.Text = "关于软件";
            // 
            // MainToolMenu
            // 
            this.MainToolMenu.BackColor = System.Drawing.Color.Transparent;
            this.MainToolMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainToolMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveCfg,
            this.btnLoadCfg,
            this.btnOutputSet,
            this.btnOutputCover,
            this.btnQuit,
            this.btnChanGen,
            this.btnCfgFPGA,
            this.btnRunFPGA,
            this.btnChanFig});
            this.MainToolMenu.Location = new System.Drawing.Point(0, 27);
            this.MainToolMenu.Name = "MainToolMenu";
            this.MainToolMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainToolMenu.Size = new System.Drawing.Size(969, 27);
            this.MainToolMenu.TabIndex = 39;
            // 
            // btnSaveCfg
            // 
            this.btnSaveCfg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveCfg.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveCfg.ForeColor = System.Drawing.Color.Black;
            this.btnSaveCfg.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveCfg.Image")));
            this.btnSaveCfg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveCfg.Name = "btnSaveCfg";
            this.btnSaveCfg.Size = new System.Drawing.Size(24, 24);
            this.btnSaveCfg.Tag = "";
            this.btnSaveCfg.ToolTipText = "保存当前页面配置";
            // 
            // btnLoadCfg
            // 
            this.btnLoadCfg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLoadCfg.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLoadCfg.ForeColor = System.Drawing.Color.Black;
            this.btnLoadCfg.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadCfg.Image")));
            this.btnLoadCfg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadCfg.Name = "btnLoadCfg";
            this.btnLoadCfg.Size = new System.Drawing.Size(24, 24);
            this.btnLoadCfg.Tag = "";
            this.btnLoadCfg.ToolTipText = "载入当前页面配置";
            // 
            // btnOutputSet
            // 
            this.btnOutputSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOutputSet.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOutputSet.ForeColor = System.Drawing.Color.Black;
            this.btnOutputSet.Image = ((System.Drawing.Image)(resources.GetObject("btnOutputSet.Image")));
            this.btnOutputSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutputSet.Name = "btnOutputSet";
            this.btnOutputSet.Size = new System.Drawing.Size(24, 24);
            this.btnOutputSet.Tag = "";
            this.btnOutputSet.ToolTipText = "设置文件输出目录";
            // 
            // btnOutputCover
            // 
            this.btnOutputCover.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOutputCover.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOutputCover.ForeColor = System.Drawing.Color.Black;
            this.btnOutputCover.Image = ((System.Drawing.Image)(resources.GetObject("btnOutputCover.Image")));
            this.btnOutputCover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutputCover.Name = "btnOutputCover";
            this.btnOutputCover.Size = new System.Drawing.Size(24, 24);
            this.btnOutputCover.Tag = "";
            this.btnOutputCover.ToolTipText = "设置输出文件是否覆盖上一次运行结果";
            // 
            // btnQuit
            // 
            this.btnQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnQuit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuit.ForeColor = System.Drawing.Color.Black;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(24, 24);
            this.btnQuit.Tag = "";
            this.btnQuit.ToolTipText = "退出程序";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnChanGen
            // 
            this.btnChanGen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnChanGen.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChanGen.ForeColor = System.Drawing.Color.Black;
            this.btnChanGen.Image = ((System.Drawing.Image)(resources.GetObject("btnChanGen.Image")));
            this.btnChanGen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChanGen.Name = "btnChanGen";
            this.btnChanGen.Size = new System.Drawing.Size(24, 24);
            this.btnChanGen.Tag = "";
            this.btnChanGen.ToolTipText = "通过信道参数对信道进行仿真";
            // 
            // btnCfgFPGA
            // 
            this.btnCfgFPGA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCfgFPGA.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCfgFPGA.ForeColor = System.Drawing.Color.Black;
            this.btnCfgFPGA.Image = ((System.Drawing.Image)(resources.GetObject("btnCfgFPGA.Image")));
            this.btnCfgFPGA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCfgFPGA.Name = "btnCfgFPGA";
            this.btnCfgFPGA.Size = new System.Drawing.Size(24, 24);
            this.btnCfgFPGA.Tag = "";
            this.btnCfgFPGA.ToolTipText = "配置硬件";
            // 
            // btnRunFPGA
            // 
            this.btnRunFPGA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRunFPGA.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRunFPGA.ForeColor = System.Drawing.Color.Black;
            this.btnRunFPGA.Image = ((System.Drawing.Image)(resources.GetObject("btnRunFPGA.Image")));
            this.btnRunFPGA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRunFPGA.Name = "btnRunFPGA";
            this.btnRunFPGA.Size = new System.Drawing.Size(24, 24);
            this.btnRunFPGA.Tag = "";
            this.btnRunFPGA.ToolTipText = "启动或停止设备";
            // 
            // btnChanFig
            // 
            this.btnChanFig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnChanFig.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChanFig.ForeColor = System.Drawing.Color.Black;
            this.btnChanFig.Image = ((System.Drawing.Image)(resources.GetObject("btnChanFig.Image")));
            this.btnChanFig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChanFig.Name = "btnChanFig";
            this.btnChanFig.Size = new System.Drawing.Size(24, 24);
            this.btnChanFig.Tag = "";
            this.btnChanFig.ToolTipText = "查看最近一次浏览过的图像";
            // 
            // grpSystemPara
            // 
            this.grpSystemPara.BackColor = System.Drawing.Color.Transparent;
            this.grpSystemPara.Controls.Add(this.textBox3);
            this.grpSystemPara.Controls.Add(this.label5);
            this.grpSystemPara.Controls.Add(this.txtAeroCarrierFre);
            this.grpSystemPara.Controls.Add(this.lalAeroCarrierFre);
            this.grpSystemPara.Controls.Add(this.cboSampleFre);
            this.grpSystemPara.Controls.Add(this.cboCarrierFre);
            this.grpSystemPara.Controls.Add(this.cboG2AEnv);
            this.grpSystemPara.Controls.Add(this.lalAeroUpdateUnit);
            this.grpSystemPara.Controls.Add(this.label4);
            this.grpSystemPara.Controls.Add(this.txtAeroUpdate);
            this.grpSystemPara.Controls.Add(this.lalAeroUpdate);
            this.grpSystemPara.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.grpSystemPara.ForeColor = System.Drawing.Color.Black;
            this.grpSystemPara.Location = new System.Drawing.Point(11, 483);
            this.grpSystemPara.Name = "grpSystemPara";
            this.grpSystemPara.Size = new System.Drawing.Size(469, 124);
            this.grpSystemPara.TabIndex = 61;
            this.grpSystemPara.TabStop = false;
            this.grpSystemPara.Text = "系统参数";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(298, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(85, 29);
            this.textBox3.TabIndex = 98;
            this.textBox3.Text = "100";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(187, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 100;
            this.label5.Text = "信道采样率";
            // 
            // txtAeroCarrierFre
            // 
            this.txtAeroCarrierFre.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAeroCarrierFre.Location = new System.Drawing.Point(298, 78);
            this.txtAeroCarrierFre.Name = "txtAeroCarrierFre";
            this.txtAeroCarrierFre.Size = new System.Drawing.Size(85, 29);
            this.txtAeroCarrierFre.TabIndex = 95;
            this.txtAeroCarrierFre.Text = "100";
            this.txtAeroCarrierFre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lalAeroCarrierFre
            // 
            this.lalAeroCarrierFre.AutoSize = true;
            this.lalAeroCarrierFre.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalAeroCarrierFre.ForeColor = System.Drawing.Color.Black;
            this.lalAeroCarrierFre.Location = new System.Drawing.Point(207, 82);
            this.lalAeroCarrierFre.Name = "lalAeroCarrierFre";
            this.lalAeroCarrierFre.Size = new System.Drawing.Size(90, 21);
            this.lalAeroCarrierFre.TabIndex = 97;
            this.lalAeroCarrierFre.Text = "载波频率";
            // 
            // cboSampleFre
            // 
            this.cboSampleFre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cboSampleFre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSampleFre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboSampleFre.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.cboSampleFre.ForeColor = System.Drawing.Color.Black;
            this.cboSampleFre.FormattingEnabled = true;
            this.cboSampleFre.Items.AddRange(new object[] {
            "GHz",
            "MHz",
            "KHz",
            "Hz"});
            this.cboSampleFre.Location = new System.Drawing.Point(389, 32);
            this.cboSampleFre.Name = "cboSampleFre";
            this.cboSampleFre.Size = new System.Drawing.Size(62, 30);
            this.cboSampleFre.TabIndex = 99;
            // 
            // cboCarrierFre
            // 
            this.cboCarrierFre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cboCarrierFre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarrierFre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboCarrierFre.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.cboCarrierFre.ForeColor = System.Drawing.Color.Black;
            this.cboCarrierFre.FormattingEnabled = true;
            this.cboCarrierFre.Items.AddRange(new object[] {
            "GHz",
            "MHz",
            "KHz",
            "Hz"});
            this.cboCarrierFre.Location = new System.Drawing.Point(389, 78);
            this.cboCarrierFre.Name = "cboCarrierFre";
            this.cboCarrierFre.Size = new System.Drawing.Size(62, 30);
            this.cboCarrierFre.TabIndex = 96;
            // 
            // cboG2AEnv
            // 
            this.cboG2AEnv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cboG2AEnv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboG2AEnv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboG2AEnv.ForeColor = System.Drawing.Color.Black;
            this.cboG2AEnv.FormattingEnabled = true;
            this.cboG2AEnv.Items.AddRange(new object[] {
            "丘陵",
            "山区",
            "海洋"});
            this.cboG2AEnv.Location = new System.Drawing.Point(111, 32);
            this.cboG2AEnv.Name = "cboG2AEnv";
            this.cboG2AEnv.Size = new System.Drawing.Size(67, 28);
            this.cboG2AEnv.TabIndex = 12;
            // 
            // lalAeroUpdateUnit
            // 
            this.lalAeroUpdateUnit.AutoSize = true;
            this.lalAeroUpdateUnit.BackColor = System.Drawing.Color.Transparent;
            this.lalAeroUpdateUnit.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalAeroUpdateUnit.ForeColor = System.Drawing.Color.Black;
            this.lalAeroUpdateUnit.Location = new System.Drawing.Point(180, 81);
            this.lalAeroUpdateUnit.Name = "lalAeroUpdateUnit";
            this.lalAeroUpdateUnit.Size = new System.Drawing.Size(18, 23);
            this.lalAeroUpdateUnit.TabIndex = 91;
            this.lalAeroUpdateUnit.Text = "s";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 67;
            this.label4.Text = "通信环境";
            // 
            // txtAeroUpdate
            // 
            this.txtAeroUpdate.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtAeroUpdate.Location = new System.Drawing.Point(110, 78);
            this.txtAeroUpdate.Name = "txtAeroUpdate";
            this.txtAeroUpdate.Size = new System.Drawing.Size(68, 29);
            this.txtAeroUpdate.TabIndex = 89;
            this.txtAeroUpdate.Text = "10";
            this.txtAeroUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lalAeroUpdate
            // 
            this.lalAeroUpdate.AutoSize = true;
            this.lalAeroUpdate.BackColor = System.Drawing.Color.Transparent;
            this.lalAeroUpdate.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalAeroUpdate.ForeColor = System.Drawing.Color.Black;
            this.lalAeroUpdate.Location = new System.Drawing.Point(17, 82);
            this.lalAeroUpdate.Name = "lalAeroUpdate";
            this.lalAeroUpdate.Size = new System.Drawing.Size(90, 21);
            this.lalAeroUpdate.TabIndex = 90;
            this.lalAeroUpdate.Text = "仿真时间";
            // 
            // statusShow
            // 
            this.statusShow.AutoSize = false;
            this.statusShow.BackColor = System.Drawing.Color.Transparent;
            this.statusShow.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.statusShow.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusShow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lalOutputPath,
            this.lblDateNow});
            this.statusShow.Location = new System.Drawing.Point(0, 625);
            this.statusShow.Name = "statusShow";
            this.statusShow.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusShow.Size = new System.Drawing.Size(969, 30);
            this.statusShow.SizingGrip = false;
            this.statusShow.TabIndex = 62;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(70, 25);
            this.lblStatus.Text = "Ready";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lalOutputPath
            // 
            this.lalOutputPath.ActiveLinkColor = System.Drawing.Color.Teal;
            this.lalOutputPath.AutoToolTip = true;
            this.lalOutputPath.BackColor = System.Drawing.Color.Transparent;
            this.lalOutputPath.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lalOutputPath.ForeColor = System.Drawing.Color.Black;
            this.lalOutputPath.IsLink = true;
            this.lalOutputPath.LinkColor = System.Drawing.Color.Black;
            this.lalOutputPath.Name = "lalOutputPath";
            this.lalOutputPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lalOutputPath.Size = new System.Drawing.Size(30, 25);
            this.lalOutputPath.Text = "C:\\";
            this.lalOutputPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateNow
            // 
            this.lblDateNow.BackColor = System.Drawing.Color.Transparent;
            this.lblDateNow.ForeColor = System.Drawing.Color.Black;
            this.lblDateNow.Name = "lblDateNow";
            this.lblDateNow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDateNow.Size = new System.Drawing.Size(854, 25);
            this.lblDateNow.Spring = true;
            this.lblDateNow.Text = "2016年09月03日";
            this.lblDateNow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpLaun
            // 
            this.grpLaun.BackColor = System.Drawing.Color.Transparent;
            this.grpLaun.Controls.Add(this.grpLaunPos);
            this.grpLaun.Controls.Add(this.grpLaunSpeed);
            this.grpLaun.Controls.Add(this.lalLaunAnte);
            this.grpLaun.Controls.Add(this.btnLaunAnte);
            this.grpLaun.Controls.Add(this.txtLaunAnte);
            this.grpLaun.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.grpLaun.ForeColor = System.Drawing.Color.Black;
            this.grpLaun.Location = new System.Drawing.Point(11, 68);
            this.grpLaun.Name = "grpLaun";
            this.grpLaun.Size = new System.Drawing.Size(469, 206);
            this.grpLaun.TabIndex = 92;
            this.grpLaun.TabStop = false;
            this.grpLaun.Text = "地面发射站";
            // 
            // grpLaunPos
            // 
            this.grpLaunPos.BackColor = System.Drawing.Color.Transparent;
            this.grpLaunPos.Controls.Add(this.lalLaunPosXUnit);
            this.grpLaunPos.Controls.Add(this.txtLaunPosX);
            this.grpLaunPos.Controls.Add(this.lalLaunPosX);
            this.grpLaunPos.Controls.Add(this.lalLaunPosYUnit);
            this.grpLaunPos.Controls.Add(this.txtLaunPosY);
            this.grpLaunPos.Controls.Add(this.lalLaunPosY);
            this.grpLaunPos.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.grpLaunPos.ForeColor = System.Drawing.Color.Black;
            this.grpLaunPos.Location = new System.Drawing.Point(15, 75);
            this.grpLaunPos.Name = "grpLaunPos";
            this.grpLaunPos.Size = new System.Drawing.Size(201, 120);
            this.grpLaunPos.TabIndex = 99;
            this.grpLaunPos.TabStop = false;
            this.grpLaunPos.Text = "起始位置";
            // 
            // lalLaunPosXUnit
            // 
            this.lalLaunPosXUnit.AutoSize = true;
            this.lalLaunPosXUnit.BackColor = System.Drawing.Color.Transparent;
            this.lalLaunPosXUnit.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalLaunPosXUnit.ForeColor = System.Drawing.Color.Black;
            this.lalLaunPosXUnit.Location = new System.Drawing.Point(168, 39);
            this.lalLaunPosXUnit.Name = "lalLaunPosXUnit";
            this.lalLaunPosXUnit.Size = new System.Drawing.Size(25, 23);
            this.lalLaunPosXUnit.TabIndex = 94;
            this.lalLaunPosXUnit.Text = "m";
            // 
            // txtLaunPosX
            // 
            this.txtLaunPosX.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtLaunPosX.Location = new System.Drawing.Point(82, 36);
            this.txtLaunPosX.Name = "txtLaunPosX";
            this.txtLaunPosX.Size = new System.Drawing.Size(85, 29);
            this.txtLaunPosX.TabIndex = 92;
            this.txtLaunPosX.Text = "100";
            this.txtLaunPosX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLaunPosX.TextChanged += new System.EventHandler(this.txtLaunRecvPos_TextChanged);
            // 
            // lalLaunPosX
            // 
            this.lalLaunPosX.AutoSize = true;
            this.lalLaunPosX.BackColor = System.Drawing.Color.Transparent;
            this.lalLaunPosX.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalLaunPosX.ForeColor = System.Drawing.Color.Black;
            this.lalLaunPosX.Location = new System.Drawing.Point(13, 40);
            this.lalLaunPosX.Name = "lalLaunPosX";
            this.lalLaunPosX.Size = new System.Drawing.Size(64, 21);
            this.lalLaunPosX.TabIndex = 93;
            this.lalLaunPosX.Text = "X方向";
            // 
            // lalLaunPosYUnit
            // 
            this.lalLaunPosYUnit.AutoSize = true;
            this.lalLaunPosYUnit.BackColor = System.Drawing.Color.Transparent;
            this.lalLaunPosYUnit.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalLaunPosYUnit.ForeColor = System.Drawing.Color.Black;
            this.lalLaunPosYUnit.Location = new System.Drawing.Point(168, 78);
            this.lalLaunPosYUnit.Name = "lalLaunPosYUnit";
            this.lalLaunPosYUnit.Size = new System.Drawing.Size(25, 23);
            this.lalLaunPosYUnit.TabIndex = 91;
            this.lalLaunPosYUnit.Text = "m";
            // 
            // txtLaunPosY
            // 
            this.txtLaunPosY.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtLaunPosY.Location = new System.Drawing.Point(82, 75);
            this.txtLaunPosY.Name = "txtLaunPosY";
            this.txtLaunPosY.Size = new System.Drawing.Size(85, 29);
            this.txtLaunPosY.TabIndex = 89;
            this.txtLaunPosY.Text = "100";
            this.txtLaunPosY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLaunPosY.TextChanged += new System.EventHandler(this.txtLaunRecvPos_TextChanged);
            // 
            // lalLaunPosY
            // 
            this.lalLaunPosY.AutoSize = true;
            this.lalLaunPosY.BackColor = System.Drawing.Color.Transparent;
            this.lalLaunPosY.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalLaunPosY.ForeColor = System.Drawing.Color.Black;
            this.lalLaunPosY.Location = new System.Drawing.Point(13, 79);
            this.lalLaunPosY.Name = "lalLaunPosY";
            this.lalLaunPosY.Size = new System.Drawing.Size(63, 21);
            this.lalLaunPosY.TabIndex = 90;
            this.lalLaunPosY.Text = "Y方向";
            // 
            // grpLaunSpeed
            // 
            this.grpLaunSpeed.BackColor = System.Drawing.Color.Transparent;
            this.grpLaunSpeed.Controls.Add(this.lalLaunSpeedXUnit);
            this.grpLaunSpeed.Controls.Add(this.txtLaunSpeedX);
            this.grpLaunSpeed.Controls.Add(this.lalLaunSpeedX);
            this.grpLaunSpeed.Controls.Add(this.lalLaunSpeedYUnit);
            this.grpLaunSpeed.Controls.Add(this.txtLaunSpeedY);
            this.grpLaunSpeed.Controls.Add(this.lalLaunSpeedY);
            this.grpLaunSpeed.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.grpLaunSpeed.ForeColor = System.Drawing.Color.Black;
            this.grpLaunSpeed.Location = new System.Drawing.Point(229, 75);
            this.grpLaunSpeed.Name = "grpLaunSpeed";
            this.grpLaunSpeed.Size = new System.Drawing.Size(226, 120);
            this.grpLaunSpeed.TabIndex = 98;
            this.grpLaunSpeed.TabStop = false;
            this.grpLaunSpeed.Text = "移动速度";
            // 
            // lalLaunSpeedXUnit
            // 
            this.lalLaunSpeedXUnit.AutoSize = true;
            this.lalLaunSpeedXUnit.BackColor = System.Drawing.Color.Transparent;
            this.lalLaunSpeedXUnit.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalLaunSpeedXUnit.ForeColor = System.Drawing.Color.Black;
            this.lalLaunSpeedXUnit.Location = new System.Drawing.Point(171, 39);
            this.lalLaunSpeedXUnit.Name = "lalLaunSpeedXUnit";
            this.lalLaunSpeedXUnit.Size = new System.Drawing.Size(40, 23);
            this.lalLaunSpeedXUnit.TabIndex = 94;
            this.lalLaunSpeedXUnit.Text = "m/s";
            // 
            // txtLaunSpeedX
            // 
            this.txtLaunSpeedX.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtLaunSpeedX.Location = new System.Drawing.Point(85, 36);
            this.txtLaunSpeedX.Name = "txtLaunSpeedX";
            this.txtLaunSpeedX.Size = new System.Drawing.Size(85, 29);
            this.txtLaunSpeedX.TabIndex = 92;
            this.txtLaunSpeedX.Text = "10";
            this.txtLaunSpeedX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lalLaunSpeedX
            // 
            this.lalLaunSpeedX.AutoSize = true;
            this.lalLaunSpeedX.BackColor = System.Drawing.Color.Transparent;
            this.lalLaunSpeedX.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalLaunSpeedX.ForeColor = System.Drawing.Color.Black;
            this.lalLaunSpeedX.Location = new System.Drawing.Point(16, 40);
            this.lalLaunSpeedX.Name = "lalLaunSpeedX";
            this.lalLaunSpeedX.Size = new System.Drawing.Size(64, 21);
            this.lalLaunSpeedX.TabIndex = 93;
            this.lalLaunSpeedX.Text = "X方向";
            // 
            // lalLaunSpeedYUnit
            // 
            this.lalLaunSpeedYUnit.AutoSize = true;
            this.lalLaunSpeedYUnit.BackColor = System.Drawing.Color.Transparent;
            this.lalLaunSpeedYUnit.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalLaunSpeedYUnit.ForeColor = System.Drawing.Color.Black;
            this.lalLaunSpeedYUnit.Location = new System.Drawing.Point(171, 78);
            this.lalLaunSpeedYUnit.Name = "lalLaunSpeedYUnit";
            this.lalLaunSpeedYUnit.Size = new System.Drawing.Size(40, 23);
            this.lalLaunSpeedYUnit.TabIndex = 91;
            this.lalLaunSpeedYUnit.Text = "m/s";
            // 
            // txtLaunSpeedY
            // 
            this.txtLaunSpeedY.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtLaunSpeedY.Location = new System.Drawing.Point(85, 75);
            this.txtLaunSpeedY.Name = "txtLaunSpeedY";
            this.txtLaunSpeedY.Size = new System.Drawing.Size(85, 29);
            this.txtLaunSpeedY.TabIndex = 89;
            this.txtLaunSpeedY.Text = "10";
            this.txtLaunSpeedY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lalLaunSpeedY
            // 
            this.lalLaunSpeedY.AutoSize = true;
            this.lalLaunSpeedY.BackColor = System.Drawing.Color.Transparent;
            this.lalLaunSpeedY.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalLaunSpeedY.ForeColor = System.Drawing.Color.Black;
            this.lalLaunSpeedY.Location = new System.Drawing.Point(16, 79);
            this.lalLaunSpeedY.Name = "lalLaunSpeedY";
            this.lalLaunSpeedY.Size = new System.Drawing.Size(63, 21);
            this.lalLaunSpeedY.TabIndex = 90;
            this.lalLaunSpeedY.Text = "Y方向";
            // 
            // lalLaunAnte
            // 
            this.lalLaunAnte.AutoSize = true;
            this.lalLaunAnte.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalLaunAnte.ForeColor = System.Drawing.Color.Black;
            this.lalLaunAnte.Location = new System.Drawing.Point(22, 38);
            this.lalLaunAnte.Name = "lalLaunAnte";
            this.lalLaunAnte.Size = new System.Drawing.Size(90, 21);
            this.lalLaunAnte.TabIndex = 85;
            this.lalLaunAnte.Text = "天线增益";
            // 
            // btnLaunAnte
            // 
            this.btnLaunAnte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLaunAnte.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.btnLaunAnte.ForeColor = System.Drawing.Color.Black;
            this.btnLaunAnte.Location = new System.Drawing.Point(397, 30);
            this.btnLaunAnte.Name = "btnLaunAnte";
            this.btnLaunAnte.Size = new System.Drawing.Size(37, 37);
            this.btnLaunAnte.TabIndex = 84;
            this.btnLaunAnte.TabStop = false;
            this.btnLaunAnte.Text = "...";
            this.btnLaunAnte.UseVisualStyleBackColor = false;
            // 
            // txtLaunAnte
            // 
            this.txtLaunAnte.AllowDrop = true;
            this.txtLaunAnte.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtLaunAnte.Location = new System.Drawing.Point(121, 33);
            this.txtLaunAnte.Name = "txtLaunAnte";
            this.txtLaunAnte.Size = new System.Drawing.Size(270, 29);
            this.txtLaunAnte.TabIndex = 83;
            // 
            // chtRelayNet
            // 
            this.chtRelayNet.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 85F;
            chartArea1.InnerPlotPosition.Width = 85F;
            chartArea1.InnerPlotPosition.X = 13F;
            chartArea1.InnerPlotPosition.Y = 3.90957F;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 80F;
            this.chtRelayNet.ChartAreas.Add(chartArea1);
            legend1.AutoFitMinFontSize = 8;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsDockedInsideChartArea = false;
            legend1.IsTextAutoFit = false;
            legend1.ItemColumnSpacing = 0;
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 25F;
            legend1.Position.Width = 22F;
            legend1.Position.X = 78F;
            legend1.Position.Y = 4F;
            legend1.TitleBackColor = System.Drawing.Color.Transparent;
            this.chtRelayNet.Legends.Add(legend1);
            this.chtRelayNet.Location = new System.Drawing.Point(486, 280);
            this.chtRelayNet.Name = "chtRelayNet";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.LegendText = "发射站";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.Magenta;
            series2.Legend = "Legend1";
            series2.LegendText = "接收站";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Color = System.Drawing.Color.Teal;
            series3.Legend = "Legend1";
            series3.LegendText = "中继节点";
            series3.Name = "Series3";
            series3.YValuesPerPoint = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Green;
            series4.Legend = "Legend1";
            series4.LegendText = "通信链路";
            series4.Name = "Series4";
            this.chtRelayNet.Series.Add(series1);
            this.chtRelayNet.Series.Add(series2);
            this.chtRelayNet.Series.Add(series3);
            this.chtRelayNet.Series.Add(series4);
            this.chtRelayNet.Size = new System.Drawing.Size(471, 337);
            this.chtRelayNet.TabIndex = 93;
            this.chtRelayNet.Text = "chart1";
            // 
            // grpRelay
            // 
            this.grpRelay.BackColor = System.Drawing.Color.Transparent;
            this.grpRelay.Controls.Add(this.lalCoverAreaUnit);
            this.grpRelay.Controls.Add(this.txtCoverArea);
            this.grpRelay.Controls.Add(this.lalCoverArea);
            this.grpRelay.Controls.Add(this.lalAFGainUnit);
            this.grpRelay.Controls.Add(this.txtAFGain);
            this.grpRelay.Controls.Add(this.lalAFGain);
            this.grpRelay.Controls.Add(this.lalFlightHeightUnit);
            this.grpRelay.Controls.Add(this.txtFlightHeight);
            this.grpRelay.Controls.Add(this.lalFlightHeight);
            this.grpRelay.Controls.Add(this.lalRelayAnte);
            this.grpRelay.Controls.Add(this.btnRelayAnte);
            this.grpRelay.Controls.Add(this.txtRelayAnte);
            this.grpRelay.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.grpRelay.ForeColor = System.Drawing.Color.Black;
            this.grpRelay.Location = new System.Drawing.Point(11, 297);
            this.grpRelay.Name = "grpRelay";
            this.grpRelay.Size = new System.Drawing.Size(468, 159);
            this.grpRelay.TabIndex = 93;
            this.grpRelay.TabStop = false;
            this.grpRelay.Text = "中继节点";
            // 
            // lalCoverAreaUnit
            // 
            this.lalCoverAreaUnit.AutoSize = true;
            this.lalCoverAreaUnit.BackColor = System.Drawing.Color.Transparent;
            this.lalCoverAreaUnit.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalCoverAreaUnit.ForeColor = System.Drawing.Color.Black;
            this.lalCoverAreaUnit.Location = new System.Drawing.Point(243, 119);
            this.lalCoverAreaUnit.Name = "lalCoverAreaUnit";
            this.lalCoverAreaUnit.Size = new System.Drawing.Size(25, 23);
            this.lalCoverAreaUnit.TabIndex = 97;
            this.lalCoverAreaUnit.Text = "m";
            // 
            // txtCoverArea
            // 
            this.txtCoverArea.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtCoverArea.Location = new System.Drawing.Point(157, 116);
            this.txtCoverArea.Name = "txtCoverArea";
            this.txtCoverArea.Size = new System.Drawing.Size(85, 29);
            this.txtCoverArea.TabIndex = 95;
            this.txtCoverArea.Text = "2000";
            this.txtCoverArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCoverArea.TextChanged += new System.EventHandler(this.txtCoverArea_TextChanged);
            // 
            // lalCoverArea
            // 
            this.lalCoverArea.AutoSize = true;
            this.lalCoverArea.BackColor = System.Drawing.Color.Transparent;
            this.lalCoverArea.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalCoverArea.ForeColor = System.Drawing.Color.Black;
            this.lalCoverArea.Location = new System.Drawing.Point(20, 120);
            this.lalCoverArea.Name = "lalCoverArea";
            this.lalCoverArea.Size = new System.Drawing.Size(130, 21);
            this.lalCoverArea.TabIndex = 96;
            this.lalCoverArea.Text = "覆盖区域边长";
            // 
            // lalAFGainUnit
            // 
            this.lalAFGainUnit.AutoSize = true;
            this.lalAFGainUnit.BackColor = System.Drawing.Color.Transparent;
            this.lalAFGainUnit.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalAFGainUnit.ForeColor = System.Drawing.Color.Black;
            this.lalAFGainUnit.Location = new System.Drawing.Point(205, 77);
            this.lalAFGainUnit.Name = "lalAFGainUnit";
            this.lalAFGainUnit.Size = new System.Drawing.Size(31, 23);
            this.lalAFGainUnit.TabIndex = 94;
            this.lalAFGainUnit.Text = "dB";
            // 
            // txtAFGain
            // 
            this.txtAFGain.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtAFGain.Location = new System.Drawing.Point(119, 74);
            this.txtAFGain.Name = "txtAFGain";
            this.txtAFGain.Size = new System.Drawing.Size(85, 29);
            this.txtAFGain.TabIndex = 92;
            this.txtAFGain.Text = "10";
            this.txtAFGain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lalAFGain
            // 
            this.lalAFGain.AutoSize = true;
            this.lalAFGain.BackColor = System.Drawing.Color.Transparent;
            this.lalAFGain.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalAFGain.ForeColor = System.Drawing.Color.Black;
            this.lalAFGain.Location = new System.Drawing.Point(20, 78);
            this.lalAFGain.Name = "lalAFGain";
            this.lalAFGain.Size = new System.Drawing.Size(90, 21);
            this.lalAFGain.TabIndex = 93;
            this.lalAFGain.Text = "转发增益";
            // 
            // lalFlightHeightUnit
            // 
            this.lalFlightHeightUnit.AutoSize = true;
            this.lalFlightHeightUnit.BackColor = System.Drawing.Color.Transparent;
            this.lalFlightHeightUnit.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalFlightHeightUnit.ForeColor = System.Drawing.Color.Black;
            this.lalFlightHeightUnit.Location = new System.Drawing.Point(425, 77);
            this.lalFlightHeightUnit.Name = "lalFlightHeightUnit";
            this.lalFlightHeightUnit.Size = new System.Drawing.Size(25, 23);
            this.lalFlightHeightUnit.TabIndex = 91;
            this.lalFlightHeightUnit.Text = "m";
            // 
            // txtFlightHeight
            // 
            this.txtFlightHeight.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtFlightHeight.Location = new System.Drawing.Point(339, 74);
            this.txtFlightHeight.Name = "txtFlightHeight";
            this.txtFlightHeight.Size = new System.Drawing.Size(85, 29);
            this.txtFlightHeight.TabIndex = 89;
            this.txtFlightHeight.Text = "10";
            this.txtFlightHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lalFlightHeight
            // 
            this.lalFlightHeight.AutoSize = true;
            this.lalFlightHeight.BackColor = System.Drawing.Color.Transparent;
            this.lalFlightHeight.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalFlightHeight.ForeColor = System.Drawing.Color.Black;
            this.lalFlightHeight.Location = new System.Drawing.Point(240, 78);
            this.lalFlightHeight.Name = "lalFlightHeight";
            this.lalFlightHeight.Size = new System.Drawing.Size(90, 21);
            this.lalFlightHeight.TabIndex = 90;
            this.lalFlightHeight.Text = "飞行高度";
            // 
            // lalRelayAnte
            // 
            this.lalRelayAnte.AutoSize = true;
            this.lalRelayAnte.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalRelayAnte.ForeColor = System.Drawing.Color.Black;
            this.lalRelayAnte.Location = new System.Drawing.Point(20, 35);
            this.lalRelayAnte.Name = "lalRelayAnte";
            this.lalRelayAnte.Size = new System.Drawing.Size(90, 21);
            this.lalRelayAnte.TabIndex = 85;
            this.lalRelayAnte.Text = "天线增益";
            // 
            // btnRelayAnte
            // 
            this.btnRelayAnte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRelayAnte.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.btnRelayAnte.ForeColor = System.Drawing.Color.Black;
            this.btnRelayAnte.Location = new System.Drawing.Point(395, 27);
            this.btnRelayAnte.Name = "btnRelayAnte";
            this.btnRelayAnte.Size = new System.Drawing.Size(37, 37);
            this.btnRelayAnte.TabIndex = 84;
            this.btnRelayAnte.TabStop = false;
            this.btnRelayAnte.Text = "...";
            this.btnRelayAnte.UseVisualStyleBackColor = false;
            // 
            // txtRelayAnte
            // 
            this.txtRelayAnte.AllowDrop = true;
            this.txtRelayAnte.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtRelayAnte.Location = new System.Drawing.Point(119, 30);
            this.txtRelayAnte.Name = "txtRelayAnte";
            this.txtRelayAnte.Size = new System.Drawing.Size(270, 29);
            this.txtRelayAnte.TabIndex = 83;
            // 
            // grpRecv
            // 
            this.grpRecv.BackColor = System.Drawing.Color.Transparent;
            this.grpRecv.Controls.Add(this.grpRecvPos);
            this.grpRecv.Controls.Add(this.grpRecvSpeed);
            this.grpRecv.Controls.Add(this.lalRecvAnte);
            this.grpRecv.Controls.Add(this.btnRecvAnte);
            this.grpRecv.Controls.Add(this.txtRecvAnte);
            this.grpRecv.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.grpRecv.ForeColor = System.Drawing.Color.Black;
            this.grpRecv.Location = new System.Drawing.Point(486, 68);
            this.grpRecv.Name = "grpRecv";
            this.grpRecv.Size = new System.Drawing.Size(469, 206);
            this.grpRecv.TabIndex = 100;
            this.grpRecv.TabStop = false;
            this.grpRecv.Text = "地面接收站";
            // 
            // grpRecvPos
            // 
            this.grpRecvPos.BackColor = System.Drawing.Color.Transparent;
            this.grpRecvPos.Controls.Add(this.lalRecvPosXUnit);
            this.grpRecvPos.Controls.Add(this.txtRecvPosX);
            this.grpRecvPos.Controls.Add(this.lalRecvPosX);
            this.grpRecvPos.Controls.Add(this.lalRecvPosYUnit);
            this.grpRecvPos.Controls.Add(this.txtRecvPosY);
            this.grpRecvPos.Controls.Add(this.lalRecvPosY);
            this.grpRecvPos.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.grpRecvPos.ForeColor = System.Drawing.Color.Black;
            this.grpRecvPos.Location = new System.Drawing.Point(15, 75);
            this.grpRecvPos.Name = "grpRecvPos";
            this.grpRecvPos.Size = new System.Drawing.Size(201, 120);
            this.grpRecvPos.TabIndex = 99;
            this.grpRecvPos.TabStop = false;
            this.grpRecvPos.Text = "起始位置";
            // 
            // lalRecvPosXUnit
            // 
            this.lalRecvPosXUnit.AutoSize = true;
            this.lalRecvPosXUnit.BackColor = System.Drawing.Color.Transparent;
            this.lalRecvPosXUnit.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalRecvPosXUnit.ForeColor = System.Drawing.Color.Black;
            this.lalRecvPosXUnit.Location = new System.Drawing.Point(168, 39);
            this.lalRecvPosXUnit.Name = "lalRecvPosXUnit";
            this.lalRecvPosXUnit.Size = new System.Drawing.Size(25, 23);
            this.lalRecvPosXUnit.TabIndex = 94;
            this.lalRecvPosXUnit.Text = "m";
            // 
            // txtRecvPosX
            // 
            this.txtRecvPosX.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtRecvPosX.Location = new System.Drawing.Point(82, 36);
            this.txtRecvPosX.Name = "txtRecvPosX";
            this.txtRecvPosX.Size = new System.Drawing.Size(85, 29);
            this.txtRecvPosX.TabIndex = 92;
            this.txtRecvPosX.Text = "7900";
            this.txtRecvPosX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRecvPosX.TextChanged += new System.EventHandler(this.txtLaunRecvPos_TextChanged);
            // 
            // lalRecvPosX
            // 
            this.lalRecvPosX.AutoSize = true;
            this.lalRecvPosX.BackColor = System.Drawing.Color.Transparent;
            this.lalRecvPosX.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalRecvPosX.ForeColor = System.Drawing.Color.Black;
            this.lalRecvPosX.Location = new System.Drawing.Point(13, 40);
            this.lalRecvPosX.Name = "lalRecvPosX";
            this.lalRecvPosX.Size = new System.Drawing.Size(64, 21);
            this.lalRecvPosX.TabIndex = 93;
            this.lalRecvPosX.Text = "X方向";
            // 
            // lalRecvPosYUnit
            // 
            this.lalRecvPosYUnit.AutoSize = true;
            this.lalRecvPosYUnit.BackColor = System.Drawing.Color.Transparent;
            this.lalRecvPosYUnit.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalRecvPosYUnit.ForeColor = System.Drawing.Color.Black;
            this.lalRecvPosYUnit.Location = new System.Drawing.Point(168, 78);
            this.lalRecvPosYUnit.Name = "lalRecvPosYUnit";
            this.lalRecvPosYUnit.Size = new System.Drawing.Size(25, 23);
            this.lalRecvPosYUnit.TabIndex = 91;
            this.lalRecvPosYUnit.Text = "m";
            // 
            // txtRecvPosY
            // 
            this.txtRecvPosY.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtRecvPosY.Location = new System.Drawing.Point(82, 75);
            this.txtRecvPosY.Name = "txtRecvPosY";
            this.txtRecvPosY.Size = new System.Drawing.Size(85, 29);
            this.txtRecvPosY.TabIndex = 89;
            this.txtRecvPosY.Text = "7900";
            this.txtRecvPosY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRecvPosY.TextChanged += new System.EventHandler(this.txtLaunRecvPos_TextChanged);
            // 
            // lalRecvPosY
            // 
            this.lalRecvPosY.AutoSize = true;
            this.lalRecvPosY.BackColor = System.Drawing.Color.Transparent;
            this.lalRecvPosY.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalRecvPosY.ForeColor = System.Drawing.Color.Black;
            this.lalRecvPosY.Location = new System.Drawing.Point(13, 79);
            this.lalRecvPosY.Name = "lalRecvPosY";
            this.lalRecvPosY.Size = new System.Drawing.Size(63, 21);
            this.lalRecvPosY.TabIndex = 90;
            this.lalRecvPosY.Text = "Y方向";
            // 
            // grpRecvSpeed
            // 
            this.grpRecvSpeed.BackColor = System.Drawing.Color.Transparent;
            this.grpRecvSpeed.Controls.Add(this.lalRecvSpeedXUnit);
            this.grpRecvSpeed.Controls.Add(this.txtRecvSpeedX);
            this.grpRecvSpeed.Controls.Add(this.lalRecvSpeedX);
            this.grpRecvSpeed.Controls.Add(this.lalRecvSpeedYUnit);
            this.grpRecvSpeed.Controls.Add(this.txtRecvSpeedY);
            this.grpRecvSpeed.Controls.Add(this.lalRecvSpeedY);
            this.grpRecvSpeed.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.grpRecvSpeed.ForeColor = System.Drawing.Color.Black;
            this.grpRecvSpeed.Location = new System.Drawing.Point(229, 75);
            this.grpRecvSpeed.Name = "grpRecvSpeed";
            this.grpRecvSpeed.Size = new System.Drawing.Size(226, 120);
            this.grpRecvSpeed.TabIndex = 98;
            this.grpRecvSpeed.TabStop = false;
            this.grpRecvSpeed.Text = "移动速度";
            // 
            // lalRecvSpeedXUnit
            // 
            this.lalRecvSpeedXUnit.AutoSize = true;
            this.lalRecvSpeedXUnit.BackColor = System.Drawing.Color.Transparent;
            this.lalRecvSpeedXUnit.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalRecvSpeedXUnit.ForeColor = System.Drawing.Color.Black;
            this.lalRecvSpeedXUnit.Location = new System.Drawing.Point(171, 39);
            this.lalRecvSpeedXUnit.Name = "lalRecvSpeedXUnit";
            this.lalRecvSpeedXUnit.Size = new System.Drawing.Size(40, 23);
            this.lalRecvSpeedXUnit.TabIndex = 94;
            this.lalRecvSpeedXUnit.Text = "m/s";
            // 
            // txtRecvSpeedX
            // 
            this.txtRecvSpeedX.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtRecvSpeedX.Location = new System.Drawing.Point(85, 36);
            this.txtRecvSpeedX.Name = "txtRecvSpeedX";
            this.txtRecvSpeedX.Size = new System.Drawing.Size(85, 29);
            this.txtRecvSpeedX.TabIndex = 92;
            this.txtRecvSpeedX.Text = "10";
            this.txtRecvSpeedX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lalRecvSpeedX
            // 
            this.lalRecvSpeedX.AutoSize = true;
            this.lalRecvSpeedX.BackColor = System.Drawing.Color.Transparent;
            this.lalRecvSpeedX.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalRecvSpeedX.ForeColor = System.Drawing.Color.Black;
            this.lalRecvSpeedX.Location = new System.Drawing.Point(16, 40);
            this.lalRecvSpeedX.Name = "lalRecvSpeedX";
            this.lalRecvSpeedX.Size = new System.Drawing.Size(64, 21);
            this.lalRecvSpeedX.TabIndex = 93;
            this.lalRecvSpeedX.Text = "X方向";
            // 
            // lalRecvSpeedYUnit
            // 
            this.lalRecvSpeedYUnit.AutoSize = true;
            this.lalRecvSpeedYUnit.BackColor = System.Drawing.Color.Transparent;
            this.lalRecvSpeedYUnit.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalRecvSpeedYUnit.ForeColor = System.Drawing.Color.Black;
            this.lalRecvSpeedYUnit.Location = new System.Drawing.Point(171, 78);
            this.lalRecvSpeedYUnit.Name = "lalRecvSpeedYUnit";
            this.lalRecvSpeedYUnit.Size = new System.Drawing.Size(40, 23);
            this.lalRecvSpeedYUnit.TabIndex = 91;
            this.lalRecvSpeedYUnit.Text = "m/s";
            // 
            // txtRecvSpeedY
            // 
            this.txtRecvSpeedY.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtRecvSpeedY.Location = new System.Drawing.Point(85, 75);
            this.txtRecvSpeedY.Name = "txtRecvSpeedY";
            this.txtRecvSpeedY.Size = new System.Drawing.Size(85, 29);
            this.txtRecvSpeedY.TabIndex = 89;
            this.txtRecvSpeedY.Text = "10";
            this.txtRecvSpeedY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lalRecvSpeedY
            // 
            this.lalRecvSpeedY.AutoSize = true;
            this.lalRecvSpeedY.BackColor = System.Drawing.Color.Transparent;
            this.lalRecvSpeedY.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalRecvSpeedY.ForeColor = System.Drawing.Color.Black;
            this.lalRecvSpeedY.Location = new System.Drawing.Point(16, 79);
            this.lalRecvSpeedY.Name = "lalRecvSpeedY";
            this.lalRecvSpeedY.Size = new System.Drawing.Size(63, 21);
            this.lalRecvSpeedY.TabIndex = 90;
            this.lalRecvSpeedY.Text = "Y方向";
            // 
            // lalRecvAnte
            // 
            this.lalRecvAnte.AutoSize = true;
            this.lalRecvAnte.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalRecvAnte.ForeColor = System.Drawing.Color.Black;
            this.lalRecvAnte.Location = new System.Drawing.Point(22, 38);
            this.lalRecvAnte.Name = "lalRecvAnte";
            this.lalRecvAnte.Size = new System.Drawing.Size(90, 21);
            this.lalRecvAnte.TabIndex = 85;
            this.lalRecvAnte.Text = "天线增益";
            // 
            // btnRecvAnte
            // 
            this.btnRecvAnte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRecvAnte.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.btnRecvAnte.ForeColor = System.Drawing.Color.Black;
            this.btnRecvAnte.Location = new System.Drawing.Point(397, 30);
            this.btnRecvAnte.Name = "btnRecvAnte";
            this.btnRecvAnte.Size = new System.Drawing.Size(37, 37);
            this.btnRecvAnte.TabIndex = 84;
            this.btnRecvAnte.TabStop = false;
            this.btnRecvAnte.Text = "...";
            this.btnRecvAnte.UseVisualStyleBackColor = false;
            // 
            // txtRecvAnte
            // 
            this.txtRecvAnte.AllowDrop = true;
            this.txtRecvAnte.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtRecvAnte.Location = new System.Drawing.Point(121, 33);
            this.txtRecvAnte.Name = "txtRecvAnte";
            this.txtRecvAnte.Size = new System.Drawing.Size(270, 29);
            this.txtRecvAnte.TabIndex = 83;
            // 
            // ChanGenTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(969, 655);
            this.ControlBox = false;
            this.Controls.Add(this.grpRecv);
            this.Controls.Add(this.grpRelay);
            this.Controls.Add(this.chtRelayNet);
            this.Controls.Add(this.grpLaun);
            this.Controls.Add(this.statusShow);
            this.Controls.Add(this.grpSystemPara);
            this.Controls.Add(this.MainToolMenu);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChanGenTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "无人机中继网络仿真软件";
            this.Load += new System.EventHandler(this.ChanGenTool_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.MainToolMenu.ResumeLayout(false);
            this.MainToolMenu.PerformLayout();
            this.grpSystemPara.ResumeLayout(false);
            this.grpSystemPara.PerformLayout();
            this.statusShow.ResumeLayout(false);
            this.statusShow.PerformLayout();
            this.grpLaun.ResumeLayout(false);
            this.grpLaun.PerformLayout();
            this.grpLaunPos.ResumeLayout(false);
            this.grpLaunPos.PerformLayout();
            this.grpLaunSpeed.ResumeLayout(false);
            this.grpLaunSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtRelayNet)).EndInit();
            this.grpRelay.ResumeLayout(false);
            this.grpRelay.PerformLayout();
            this.grpRecv.ResumeLayout(false);
            this.grpRecv.PerformLayout();
            this.grpRecvPos.ResumeLayout(false);
            this.grpRecvPos.PerformLayout();
            this.grpRecvSpeed.ResumeLayout(false);
            this.grpRecvSpeed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 当前页面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 载入配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 当前页面ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 输出配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 输出路径ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 输出覆盖ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于软件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信道仿真ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配置硬件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 启动设备ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 画图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 收发端轨迹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 天线增益ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发射端ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 接收端ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip MainToolMenu;
        private System.Windows.Forms.ToolStripButton btnSaveCfg;
        private System.Windows.Forms.ToolStripButton btnLoadCfg;
        private System.Windows.Forms.ToolStripButton btnOutputSet;
        private System.Windows.Forms.ToolStripButton btnOutputCover;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnChanGen;
        private System.Windows.Forms.ToolStripButton btnCfgFPGA;
        private System.Windows.Forms.ToolStripButton btnRunFPGA;
        private System.Windows.Forms.ToolStripButton btnChanFig;
        private System.Windows.Forms.GroupBox grpSystemPara;
        private System.Windows.Forms.StatusStrip statusShow;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lalOutputPath;
        private System.Windows.Forms.ToolStripStatusLabel lblDateNow;
        private System.Windows.Forms.Label lalAeroUpdateUnit;
        private System.Windows.Forms.TextBox txtAeroUpdate;
        private System.Windows.Forms.Label lalAeroUpdate;
        private System.Windows.Forms.TextBox txtAeroCarrierFre;
        private System.Windows.Forms.Label lalAeroCarrierFre;
        private System.Windows.Forms.ComboBox cboCarrierFre;
        private System.Windows.Forms.GroupBox grpLaun;
        private System.Windows.Forms.Label lalLaunAnte;
        private System.Windows.Forms.Button btnLaunAnte;
        private System.Windows.Forms.TextBox txtLaunAnte;
        private System.Windows.Forms.ComboBox cboG2AEnv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSampleFre;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtRelayNet;
        private System.Windows.Forms.GroupBox grpRelay;
        private System.Windows.Forms.Label lalFlightHeightUnit;
        private System.Windows.Forms.TextBox txtFlightHeight;
        private System.Windows.Forms.Label lalFlightHeight;
        private System.Windows.Forms.Label lalRelayAnte;
        private System.Windows.Forms.Button btnRelayAnte;
        private System.Windows.Forms.TextBox txtRelayAnte;
        private System.Windows.Forms.Label lalAFGainUnit;
        private System.Windows.Forms.TextBox txtAFGain;
        private System.Windows.Forms.Label lalAFGain;
        private System.Windows.Forms.Label lalCoverAreaUnit;
        private System.Windows.Forms.TextBox txtCoverArea;
        private System.Windows.Forms.Label lalCoverArea;
        private System.Windows.Forms.GroupBox grpLaunPos;
        private System.Windows.Forms.Label lalLaunPosXUnit;
        private System.Windows.Forms.TextBox txtLaunPosX;
        private System.Windows.Forms.Label lalLaunPosX;
        private System.Windows.Forms.Label lalLaunPosYUnit;
        private System.Windows.Forms.TextBox txtLaunPosY;
        private System.Windows.Forms.Label lalLaunPosY;
        private System.Windows.Forms.GroupBox grpLaunSpeed;
        private System.Windows.Forms.Label lalLaunSpeedXUnit;
        private System.Windows.Forms.TextBox txtLaunSpeedX;
        private System.Windows.Forms.Label lalLaunSpeedX;
        private System.Windows.Forms.Label lalLaunSpeedYUnit;
        private System.Windows.Forms.TextBox txtLaunSpeedY;
        private System.Windows.Forms.Label lalLaunSpeedY;
        private System.Windows.Forms.GroupBox grpRecv;
        private System.Windows.Forms.GroupBox grpRecvPos;
        private System.Windows.Forms.Label lalRecvPosXUnit;
        private System.Windows.Forms.TextBox txtRecvPosX;
        private System.Windows.Forms.Label lalRecvPosX;
        private System.Windows.Forms.Label lalRecvPosYUnit;
        private System.Windows.Forms.TextBox txtRecvPosY;
        private System.Windows.Forms.Label lalRecvPosY;
        private System.Windows.Forms.GroupBox grpRecvSpeed;
        private System.Windows.Forms.Label lalRecvSpeedXUnit;
        private System.Windows.Forms.TextBox txtRecvSpeedX;
        private System.Windows.Forms.Label lalRecvSpeedX;
        private System.Windows.Forms.Label lalRecvSpeedYUnit;
        private System.Windows.Forms.TextBox txtRecvSpeedY;
        private System.Windows.Forms.Label lalRecvSpeedY;
        private System.Windows.Forms.Label lalRecvAnte;
        private System.Windows.Forms.Button btnRecvAnte;
        private System.Windows.Forms.TextBox txtRecvAnte;
    }
}

