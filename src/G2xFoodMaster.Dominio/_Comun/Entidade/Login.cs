namespace G2xFoodMaster.Dominio._Comun.Entidade
{
    public class Login
    {
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