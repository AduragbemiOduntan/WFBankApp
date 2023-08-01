using System.ComponentModel.DataAnnotations;

namespace WFBankApp.Share.DTOs.CreationDto
{
    public class BankTransactionCreatitionDto
    {
        [Required(ErrorMessage = "Please provide a transaction amount.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Transaction amount must be greater than 0.")]
        public double TransactionAmount { get; set; }

        [Required(ErrorMessage = "Please provide an account number.")]
        [StringLength(20, ErrorMessage = "Account number must not exceed 20 characters.")]
        public string AccountNumber { get; set; }

        [Required(ErrorMessage = "Please provide a destination account.")]
        [StringLength(20, ErrorMessage = "Destination account must not exceed 20 characters.")]
        public string DestinationAccount { get; set; }

        [StringLength(200, ErrorMessage = "Transaction description must not exceed 200 characters.")]
        public string TransactionDescription { get; set; }

        [Required(ErrorMessage = "Please provide a transaction type.")]
        public TransactionType TransactionType { get; set; }
    }

    public enum TransactionType
    {
        Deposit,
        Withdrawal,
        Transfer
    }

}
