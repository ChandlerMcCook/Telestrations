namespace TelestrationsUI.Forms;

partial class frmZoomPaint
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        trkAngle = new TrackBar();
        ((System.ComponentModel.ISupportInitialize)trkAngle).BeginInit();
        SuspendLayout();
        // 
        // trkAngle
        // 
        trkAngle.Location = new Point(45, 847);
        trkAngle.Maximum = 360;
        trkAngle.Name = "trkAngle";
        trkAngle.Size = new Size(636, 69);
        trkAngle.TabIndex = 0;
        // 
        // frmZoomPaint
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1305, 1038);
        Controls.Add(trkAngle);
        Name = "frmZoomPaint";
        Text = "frmZoomPaint";
        ((System.ComponentModel.ISupportInitialize)trkAngle).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TrackBar trkAngle;
}