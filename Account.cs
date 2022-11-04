using System.Runtime.Serialization;

namespace Organizer.Model
{
    [DataContract]
    public class Account
    {
        [DataMember]private string login;
        [DataMember]private string password;
        [DataMember]private bool isAdmin;

        public Account(string login, string password, bool isAdmin)
        {
            this.Login = login;
            this.Password = password;
            this.IsAdmin = isAdmin;
        }

        #region Getters & Setters
        public string Login
        {
            get => login;
            set => login = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public bool IsAdmin
        {
            get => isAdmin;
            set => isAdmin = value;
        }
        #endregion

        public static bool operator ==(Account tmp1, Account tmp2) => tmp1.isAdmin == tmp2.isAdmin &&
                                                                      tmp1.login == tmp2.login &&
                                                                      tmp1.password == tmp2.password;

        public static bool operator !=(Account tmp1, Account tmp2) => !(tmp1.isAdmin == tmp2.isAdmin &&
                                                                        tmp1.login == tmp2.login &&
                                                                        tmp1.password == tmp2.password);
    }
}