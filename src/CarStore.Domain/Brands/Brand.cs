using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;
using JetBrains.Annotations;
using Volo.Abp;

namespace CarStore.Brands
{
    public class Brand : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; private set; }
        public DateTime BirthDate { get; set; }
        public string Group { get; set; }

        public Brand()
        {

        }

        internal Brand(
            Guid id,
            [NotNull] string name,
            DateTime birthDate,
            [CanBeNull] string group = null)
            : base(id)
        {
            SetName(name);
            BirthDate = birthDate;
            Group = group;
        }

        internal Brand ChangeName([NotNull] string name)
        {
            SetName(name);
            return this;
        }

        private void SetName([NotNull]string name)
        {
            Name = Check.NotNullOrWhiteSpace(name, nameof(name), maxLength: BrandConsts.MaxNameLength);
        }
    }
}
