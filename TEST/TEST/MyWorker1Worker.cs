using Soneta.Business;
using Soneta.Business.UI;
using Soneta.Handel;
using System;
using TEST;

[assembly: Worker(typeof(MyWorker1Worker), typeof(DokHandlowe))]

namespace TEST
{
	public class MyWorker1Worker
	{


		// TODO -> Należy podmienić podany opis akcji na bardziej czytelny dla uzytkownika
		[Action("MyWorker1Worker/ToDo", Mode = ActionMode.SingleSession | ActionMode.ConfirmSave | ActionMode.Progress)]
		public MessageBoxInformation ToDo()
		{

			return new MessageBoxInformation("Czy wykonać operację????")
			{
				Text = "Opis operacji",
				YesHandler = () => "Operacja została zakończona!!",
				NoHandler = () => "Operacja przerwana........"
			};


		}
	}


}
