namespace dotdigital.Api.Resources.Enums
{
	public enum ApiTransactionalDataImportFaultReason
	{
		Unknown,
		InvalidClientKey,
		InvalidContactIdentifier,
		InvalidJson,
		DuplicateKey,
		ContactIdDoesNotExist,
		ContactEmailDoesNotExist,
		JsonKeyTooLong,
		JsonKeyInvalidCharacters,
		JsonValueTooLong,
		JsonValueIncompatibleWithSchema,
		JsonNumberValueTooLarge,
		JsonDoesNotMatchSchema,
		JsonContainsDashUnderscoreClash,
		MissingCollection,
		InconsistentTypes,
		NotAvailableInThisVersion
	}
}
