﻿using System.Data.Entity.ModelConfiguration;
using DXApplication1.DataLayer.Models;

namespace DXApplication1.DataLayer.Configurations
{
    internal sealed class InspectionConfiguration: EntityTypeConfiguration<Inspection>
    {
        public InspectionConfiguration()
        {
            HasKey(inspection => inspection.Id);
        }
    }
}
