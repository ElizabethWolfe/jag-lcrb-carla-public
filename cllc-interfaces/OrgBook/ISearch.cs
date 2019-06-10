// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Search operations.
    /// </summary>
    public partial interface ISearch
    {
        /// <param name='q'>
        /// A query
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<AutocompleteOKResponse>> AutocompleteWithHttpMessagesAsync(string q = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// We want facet_counts from the less-restricted queryset
        /// </summary>
        /// <param name='ordering'>
        /// Which field to use when ordering the results.
        /// </param>
        /// <param name='inactive'>
        /// True to include inactive companies
        /// </param>
        /// <param name='page'>
        /// A page number within the paginated result set.
        /// </param>
        /// <param name='pageSize'>
        /// Number of results to return per page.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<CredentialTopicFacetsOKResponse>> CredentialTopicFacetsWithHttpMessagesAsync(string ordering = default(string), bool? inactive = default(bool?), int? page = default(int?), int? pageSize = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}