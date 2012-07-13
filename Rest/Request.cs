using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;

namespace OakIdeas.SinglySharp.Rest
{
    public class Request
    {
        /// <summary>
        /// Builds a get request
        /// </summary>
        /// <param name="resource">The URL resource that you are trying to reach</param>
        /// <param name="parameters">The list of parameters</param>
        /// <returns>The rest request object</returns>
        public static RestRequest GetRequest(string resource, params Parameter[] parameters)
        {
            RestRequest restRequest = new RestRequest(resource);
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.Method = Method.GET;

            foreach (Parameter parameter in parameters)
            {
                restRequest.AddParameter(parameter);
            }

            return restRequest;
        }

        /// <summary>
        /// Builds a post request
        /// </summary>
        /// <param name="resource">The URL resource that you are trying to reach</param>
        /// <param name="parameters">The list of parameters</param>
        /// <returns>The rest request object</returns>
        public static RestRequest PostRequest(string resource, params Parameter[] parameters)
        {
            RestRequest restRequest = new RestRequest(resource);
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.Method = Method.POST;

            foreach (Parameter parameter in parameters)
            {
                restRequest.AddParameter(parameter);
            }

            return restRequest;
        }

        /// <summary>
        /// Builds a update request
        /// </summary>
        /// <param name="resource">The URL resource that you are trying to reach</param>
        /// <param name="parameters">The list of parameters</param>
        /// <returns>The rest request object</returns>
        public static RestRequest UpdateRequest(string resource, params Parameter[] parameters)
        {
            RestRequest restRequest = new RestRequest(resource);
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.Method = Method.PUT;

            foreach (Parameter parameter in parameters)
            {
                restRequest.AddParameter(parameter);
            }

            return restRequest;
        }

        /// <summary>
        /// Builds a delete request
        /// </summary>
        /// <param name="resource">The URL resource that you are trying to reach</param>
        /// <param name="parameters">The list of parameters</param>
        /// <returns>The rest request object</returns>
        public static RestRequest DeleteRequest(string resource, params Parameter[] parameters)
        {
            RestRequest restRequest = new RestRequest(resource);
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.Method = Method.DELETE;

            foreach (Parameter parameter in parameters)
            {
                restRequest.AddParameter(parameter);
            }

            return restRequest;
        }

    }
}
