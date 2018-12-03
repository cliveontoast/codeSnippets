    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new System.DirectoryServices.AccountManagement.PrincipalContext(System.DirectoryServices.AccountManagement.ContextType.Domain))
            {
                using (var user = System.DirectoryServices.AccountManagement.UserPrincipal.FindByIdentity(context, System.DirectoryServices.AccountManagement.IdentityType.SamAccountName, "DOMAIN\\user"))
                {
                    user.ChangePassword("oldpassword", "newpassword");
                    user.Save();
                }
            }
        }
    }