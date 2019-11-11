﻿using System;

using devhl.CocApi.Models;

namespace devhl.CocApi.Exceptions
{
    [Serializable]
    public class InternalServerErrorException : ServerResponseException
    {
        public InternalServerErrorException(ResponseMessageApiModel responseMessage, System.Net.HttpStatusCode httpStatusCode) : base(responseMessage, httpStatusCode)
        {

        }

    }
}
