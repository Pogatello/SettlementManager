using SettlementManager.Model.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace SettlementManager.Model
{
    [NotMapped]
    public class CountryQuery : ValidationEntity
    {
        #region Properties

        public string SearchTerm { get; private set; }

        #endregion

        #region Constructors

        public CountryQuery(string searchTerm)
        {
            SearchTerm = searchTerm;
        }

        #endregion

        #region Public Methods

        public void Validate()
        {
            //Messages should be in separate class ex. SettlementQueryBrokenRules
            if (!string.IsNullOrEmpty(SearchTerm) && !SearchTerm.All(char.IsLetter))
            {
                AddBrokenRule("Invalid search term.");
            }

            ThrowExceptionIfThereAreBrokenRules();
        }

        #endregion
    }
}
