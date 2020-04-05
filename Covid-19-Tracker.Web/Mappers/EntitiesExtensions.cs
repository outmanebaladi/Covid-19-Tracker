using Covid_19_Tracker.Entites;
using Covid_19_Tracker.Web.Mappers.ExcelExport;
using Covid_19_Tracker.Web.Models;
using System.Collections.Generic;

namespace Covid_19_Tracker.Web.Mappers
{
	public static class EntitiesExtensions
	{
		public static CasPositifViewModel ToCasPositifViewModel(this CasPositif casPositif)
		{
			return new CasPositifViewModel
			{
				Id = casPositif.Id,
				Nom = casPositif.Nom,
				Prenom = casPositif.Prenom,
				CIN = casPositif.CIN,
				NumeroTel = casPositif.NumeroTel,
				Nombre_Contacts = casPositif.Nombre_Contacts
			};
		}

		public static CasSuiviViewModel ToCasSuiviViewModel(this CasSuivi casSuivi)
		{
			return new CasSuiviViewModel
			{
				Nom = casSuivi.Nom,
				Prenom = casSuivi.Prenom,
				CIN = casSuivi.CIN,
				NumeroTel = casSuivi.NumeroTel,
			};
		}

		public static FicheSuiviViewModel ToFicheSuiviViewModel(this FicheSuivi ficheSuivi)
		{
			return new FicheSuiviViewModel
			{
				
			};
		}

		public static IEnumerable<CasPositifViewModel> ToCasPositifViewModel(this List<CasPositif> casPositifs)
		{
			var models = new List<CasPositifViewModel>();
			foreach(var casPositif in casPositifs)
			{
				models.Add(casPositif.ToCasPositifViewModel());
			}
			return models;
		}

		public static IEnumerable<CasSuiviViewModel> ToCasSuiviViewModel(this List<CasSuivi> casSuivis)
		{
			var models = new List<CasSuiviViewModel>();
			foreach (var casSuivi in casSuivis)
			{
				models.Add(casSuivi.ToCasSuiviViewModel());
			}
			return models;
		}

		public static IEnumerable<FicheSuiviViewModel> ToFicheSuiviViewModel(this List<FicheSuivi> fichesSuivi)
		{
			var models = new List<FicheSuiviViewModel>();
			foreach (var ficheSuivi in fichesSuivi)
			{
				models.Add(ficheSuivi.ToFicheSuiviViewModel());
			}
			return models;
		}
		public static ExcelSuivi ToExcelSuivi(this FicheSuivi ficheSuivi)
		{
			return new ExcelSuivi
			{
				Id = ficheSuivi.Id.ToString(),
				NomPrenom = $"{ficheSuivi.CasSuivi.Nom} {ficheSuivi.CasSuivi.Nom}",
				DateSuivi = ficheSuivi.Date,
				Temperature_M = ficheSuivi.Temp_M,
				Temperature_S = ficheSuivi.Temp_S,
				Toux_M = ficheSuivi.Toux_M ? "OUI" : "NON",
				Toux_S = ficheSuivi.Toux_S ? "OUI" : "NON",
				Dyspnee_M = ficheSuivi.Dyspnee_M ? "OUI" : "NON",
				Dyspnee_S = ficheSuivi.Dyspnee_S ? "OUI" : "NON",
				MalAGorge_M = ficheSuivi.MalDeGorge_M ? "OUI" : "NON",
				MalAGorge_S = ficheSuivi.MalDeGorge_S ? "OUI" : "NON",
				Cephale_M = ficheSuivi.Cephalee_M ? "OUI" : "NON",
				Cephale_S = ficheSuivi.Cephalee_S ? "OUI" : "NON",
				Myalgi_M = ficheSuivi.Myalgie_M ? "OUI" : "NON",
				Myalgi_S = ficheSuivi.Myalgie_S ? "OUI" : "NON",
				Aute1_M = ficheSuivi.Autres_M,
				Autre1_S =ficheSuivi.Autres_S,
				Conclusion_M = ficheSuivi.Conclusion_M,
				Conclusion_S = ficheSuivi.Conclusion_S
			};
		}
	}
}
