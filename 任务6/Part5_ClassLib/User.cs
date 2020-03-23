namespace Part5_ClassLib
{
    /// <summary>
    /// 用户抽象
    /// 属性：用户名、密码
    /// 方法：Login 、 DisplayInfo
    /// </summary>
    public abstract class User
    {
        private string username;
        private string password;

        protected User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        protected string Username { get => username; set => username = value; }
        protected string Password { get => password; set => password = value; }

        public bool Login(string username, string password)
        {
            if (this.username == username && this.password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public abstract void DisplayInfo();
    }
}