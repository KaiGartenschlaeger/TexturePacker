using System.Drawing;

namespace TexturePacker.Objects
{
    class ImageFile
    {
        #region Constructor

        public ImageFile()
        {

        }

        #endregion

        #region Methods
        #endregion

        #region Properties

        private string m_path;
        public string Path
        {
            get { return m_path; }
            set { m_path = value; }
        }

        private string m_filename;
        public string Filename
        {
            get { return m_filename; }
            set { m_filename = value; }
        }
        
        private Image m_image;
        public Image Image
        {
            get { return m_image; }
            set { m_image = value; }
        }

        #endregion

        #region Overwrites

        public override string ToString()
        {
            return m_filename;
        }

        #endregion
    }
}