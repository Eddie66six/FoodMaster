namespace G2xFoodMaster.Dominio._Comun.Entidade
{
    public class Login
    {
        protected Login()
        {
            
        }

        public Login(string usuario, string senha)
        {
            Usuario = usuario;
            Senha = senha;
        }
        public bool Logar()
        {
            return true;
        }
        public bool ResetarSenha()
        {
            return true;
        }
        public string Usuario { get; protected set; }
        public string Senha { get; protected set; }
    }
}