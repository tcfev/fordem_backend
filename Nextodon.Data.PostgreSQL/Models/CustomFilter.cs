﻿using System;
using System.Collections.Generic;

namespace Nextodon.Data.PostgreSQL.Models;

public partial class CustomFilter
{
    public long Id { get; set; }

    public long? AccountId { get; set; }

    public DateTime? ExpiresAt { get; set; }

    public string Phrase { get; set; } = null!;

    public string[] Context { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int Action { get; set; }

    public virtual Account? Account { get; set; }

    public virtual ICollection<CustomFilterKeyword> CustomFilterKeywords { get; set; } = new List<CustomFilterKeyword>();

    public virtual ICollection<CustomFilterStatus> CustomFilterStatuses { get; set; } = new List<CustomFilterStatus>();
}
