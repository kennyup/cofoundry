﻿using Conditions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cofoundry.Domain.CQS;
using Cofoundry.Core.Validation;

namespace Cofoundry.Domain
{
    public class GetPageVersionModuleEntityMicroSummariesByIdRangeQuery : IQuery<IDictionary<int, RootEntityMicroSummary>>
    {
        public GetPageVersionModuleEntityMicroSummariesByIdRangeQuery()
        {
        }

        public GetPageVersionModuleEntityMicroSummariesByIdRangeQuery(
            IEnumerable<int> ids
            )
        {
            Condition.Requires(ids).IsNotNull();

            PageVersionModuleIds = ids.ToArray();
        }

        [Required]
        public int[] PageVersionModuleIds { get; set; }
    }
}
