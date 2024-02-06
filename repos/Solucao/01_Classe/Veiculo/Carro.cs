namespace _01_Classe.Veiculo

{
	class Carro
	{
		public string marca = "FIAT";
		public string modelo;
		public string cor;
		public bool luzesInternas = false;

		public void abrirPorta(){

			luzesInternas = true;
		}

		public void fecharPorta() {

			luzesInternas = false;		
		}

		public string acenderFarolAutomaticamente(){

			return "Médio"; 
		}


	}
}
