// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Localization;
namespace MixERP.Net.Schemas.Localization.Data
{
    public interface IAddResourceRepository
    {

        string ResourceClass { get; set; }
        string Key { get; set; }
        string Value { get; set; }

        /// <summary>
        /// Prepares and executes IAddResourceRepository.
        /// </summary>
        void Execute();
    }
}