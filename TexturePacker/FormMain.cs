using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using TexturePacker.Objects;

namespace TexturePacker
{
    public partial class FormMain : Form
    {
        #region Fields

        private List<ImageFile> _images;
        private Image _cachedImage;

        #endregion

        #region Constructor

        public FormMain()
        {
            InitializeComponent();

            _images = new List<ImageFile>();

            Helper.SetDoubleBuffered(panPreview);
            Helper.SetDoubleBuffered(pbxPreview);

            Text = Text + " Version " + Assembly.GetExecutingAssembly().GetName().Version.ToString();

            slbStatus.Text = string.Empty;
        }

        #endregion

        #region Methods

        private void RefreshPreview()
        {
            if (_images.Count > 0)
            {
                int innerPadding = (int)nudInnerPadding.Value;

                int borderSize = 0;
                if (chbBorder.Checked)
                {
                    borderSize = (int)nudBorderSize.Value;
                }

                // calculate minimum framesize
                Size minFrameSize = Size.Empty;

                if (chbFixedFrameSize.Checked)
                {
                    minFrameSize = new Size(
                        (int)nudFrameWidth.Value,
                        (int)nudFrameHeight.Value);
                }
                else
                {
                    foreach (ImageFile image in _images)
                    {
                        if (minFrameSize.Width < image.Image.Width)
                        {
                            minFrameSize.Width = image.Image.Width;
                        }
                        if (minFrameSize.Height < image.Image.Height)
                        {
                            minFrameSize.Height = image.Image.Height;
                        }
                    }
                }

                Size fixedFrameSize = new Size(
                    (int)nudFrameWidth.Value,
                    (int)nudFrameHeight.Value);

                minFrameSize.Width += innerPadding * 2;
                minFrameSize.Height += innerPadding * 2;

                if (chbBorder.Checked)
                {
                    minFrameSize.Width += borderSize * 2;
                    minFrameSize.Height += borderSize * 2;
                }

                // calculate canvas size
                int rowPadding = (int)nudRowPadding.Value;
                int columnPadding = (int)nudColumnPadding.Value;

                int minColumns = (int)nudColumns.Value;
                int minRows = (int)Math.Ceiling((double)_images.Count / minColumns);

                Size canvasSize = new Size();
                canvasSize.Width = (minColumns * minFrameSize.Width) + ((minColumns - 1) * columnPadding);
                canvasSize.Height = (minRows * minFrameSize.Height) + ((minRows - 1) * rowPadding);

                Brush brushBorder1 = new SolidBrush(btnBorderColor1.BackColor);
                Brush brushBorder2 = new SolidBrush(btnBorderColor2.BackColor);

                Bitmap previewImage = new Bitmap(canvasSize.Width, canvasSize.Height);
                using (Graphics graphics = Graphics.FromImage(previewImage))
                {
                    if (chbBackgroundTransparent.Checked)
                    {
                        graphics.Clear(Color.Transparent);
                    }
                    else
                    {
                        graphics.Clear(btnBackgroundColor.FlatAppearance.MouseOverBackColor);
                    }

                    for (int row = 0; row < minRows; row++)
                    {
                        for (int column = 0; column < minColumns; column++)
                        {
                            int index = row * minColumns + column;
                            if (index + 1 > _images.Count)
                            {
                                break;
                            }

                            int drawX = column * minFrameSize.Width + (columnPadding * column);
                            int drawY = row * minFrameSize.Height + (rowPadding * row);

                            int addDrawX = innerPadding;
                            int addDrawY = innerPadding;

                            if (chbBorder.Checked)
                            {
                                addDrawX += borderSize;
                                addDrawY += borderSize;

                                Brush brush;
                                if ((row + column) % 2 == 0)
                                {
                                    brush = brushBorder1;
                                }
                                else
                                {
                                    brush = brushBorder2;
                                }

                                graphics.FillRectangle(brush, drawX, drawY, minFrameSize.Width, borderSize);
                                graphics.FillRectangle(brush, drawX, drawY, borderSize, minFrameSize.Height);
                                graphics.FillRectangle(brush, drawX, drawY + minFrameSize.Height - borderSize, minFrameSize.Width, borderSize);
                                graphics.FillRectangle(brush, drawX + minFrameSize.Width - borderSize, drawY, borderSize, minFrameSize.Height);
                            }

                            Rectangle src;
                            if (chbFixedFrameSize.Checked)
                            {
                                src = new Rectangle(
                                    (_images[index].Image.Width - fixedFrameSize.Width) / 2,
                                    (_images[index].Image.Height - fixedFrameSize.Height) / 2,
                                    fixedFrameSize.Width,
                                    fixedFrameSize.Height);
                            }
                            else
                            {
                                src = new Rectangle(0, 0,
                                    _images[index].Image.Width,
                                    _images[index].Image.Height);
                            }

                            graphics.DrawImage(_images[index].Image,
                                drawX + addDrawX,
                                drawY + addDrawY,
                                src,
                                GraphicsUnit.Pixel);
                        }
                    }
                }

                if (_cachedImage != null)
                {
                    _cachedImage.Dispose();
                }

                _cachedImage = previewImage;
                pbxPreview.Image = previewImage;

                slbStatus.Text = string.Format("Vorschau erstellt: {0:n0}px X {1:n0}px",
                    _cachedImage.Size.Width, _cachedImage.Size.Height);
            }
            else
            {
                pbxPreview.Image = null;

            }
        }

        private void AddPictures(string[] files)
        {
            bool added = false;

            lbxFilelist.BeginUpdate();
            foreach (string path in files)
            {
                try
                {
                    Image image = Image.FromFile(path);

                    ImageFile imgFile = new ImageFile();
                    imgFile.Path = path;
                    imgFile.Filename = Path.GetFileName(path);
                    imgFile.Image = image;

                    lbxFilelist.Items.Add(imgFile);

                    _images.Add(imgFile);

                    added = true;
                }
                catch (Exception)
                {
                }
            }
            lbxFilelist.EndUpdate();

            if (added)
            {
                RefreshPreview();
            }
        }

        #endregion

        #region Toolbar Events

        private void tbbNew_Click(object sender, EventArgs e)
        {
            lbxFilelist.Items.Clear();
            _images.Clear();

            if (_cachedImage != null)
            {
                _cachedImage.Dispose();
                _cachedImage = null;
            }

            pbxPreview.Image = null;

            slbStatus.Text = string.Empty;
        }

        private void tbbSave_Click(object sender, EventArgs e)
        {
            if (_cachedImage != null)
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Title = "Speichern";
                    dialog.Filter = "Portable network graphics|*.png|Bitmap|*.bmp";

                    if (dialog.ShowDialog(this) == DialogResult.OK)
                    {
                        ImageFormat saveFormat;
                        switch (dialog.FilterIndex)
                        {
                            default:
                            case 1:
                                saveFormat = ImageFormat.Png;
                                break;
                            case 2:
                                saveFormat = ImageFormat.Bmp;
                                break;
                        }

                        try
                        {

                            _cachedImage.Save(dialog.FileName, saveFormat);

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Speichern fehlgeschlagen", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnAddPictures_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Bilder hinzufügen";
                dialog.Filter = "Bilder|*.png;*.jpg;*.bmp;*.gif";
                dialog.Multiselect = true;

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    AddPictures(dialog.FileNames);
                }
            }
        }

        #endregion

        #region Control Events

        private void panPreview_Scroll(object sender, ScrollEventArgs e)
        {
            panPreview.Refresh();
        }

        private void panPreview_Resize(object sender, EventArgs e)
        {
            panPreview.Refresh();
        }

        private void lbxFilelist_DragDrop(object sender, DragEventArgs e)
        {
            string[] paths = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (paths != null && paths.Length > 0)
            {
                AddPictures(paths);
            }
        }

        private void lbxFilelist_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            RefreshPreview();
        }

        private void nudRows_ValueChanged(object sender, EventArgs e)
        {
            RefreshPreview();
        }

        private void nudColumns_ValueChanged(object sender, EventArgs e)
        {
            RefreshPreview();
        }

        private void nudRowPadding_ValueChanged(object sender, EventArgs e)
        {
            RefreshPreview();
        }

        private void nudColumnPadding_ValueChanged(object sender, EventArgs e)
        {
            RefreshPreview();
        }

        private void nudInnerPadding_ValueChanged(object sender, EventArgs e)
        {
            RefreshPreview();
        }

        private void chbBorder_CheckedChanged(object sender, EventArgs e)
        {
            RefreshPreview();
        }

        private void chbBackgroundTransparent_CheckedChanged(object sender, EventArgs e)
        {
            RefreshPreview();
        }

        private void nudBorderSize_ValueChanged(object sender, EventArgs e)
        {
            RefreshPreview();
        }

        private void lbxFilelist_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                while (lbxFilelist.SelectedIndices.Count > 0)
                {
                    int index = lbxFilelist.SelectedIndices[lbxFilelist.SelectedIndices.Count - 1];

                    _images.RemoveAt(index);
                    lbxFilelist.Items.RemoveAt(index);
                }

                RefreshPreview();
            }
        }

        private void chbFixedFrameSize_CheckedChanged(object sender, EventArgs e)
        {
            RefreshPreview();
        }

        private void nudFrameWidth_ValueChanged(object sender, EventArgs e)
        {
            RefreshPreview();
        }

        private void nudFrameHeight_ValueChanged(object sender, EventArgs e)
        {
            RefreshPreview();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            Button btnCurrent = (Button)sender;

            using (ColorDialog dialog = new ColorDialog())
            {
                dialog.Color = btnCurrent.BackColor;

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    btnCurrent.BackColor = dialog.Color;
                    btnCurrent.FlatAppearance.MouseOverBackColor = dialog.Color;
                    btnCurrent.FlatAppearance.MouseDownBackColor = dialog.Color;

                    RefreshPreview();
                }
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright (c) Kai Gartenschläger, 2013" + Environment.NewLine + "http://www.kaisnet.de" + Environment.NewLine + "kergosoft@outlook.com", "Informationen",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }
}