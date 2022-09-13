namespace WebApiTestModel.Controllers;


// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class NaklDto
{

    private uint dwhNaklIdField;

    private byte doctypeIdField;

    private System.DateTime dateProvedField;

    private System.DateTime dateClientField;

    private byte statusField;

    private string sapCounterField;

    private ulong contractNumberField;

    private byte fromIdField;

    private byte storeIdField;

    private decimal sumNaklField;

    private decimal sumNaklNoTaxField;

    private NaklDtoNaklLines[] naklLinesField;

    /// <remarks/>
    public uint dwhNaklId
    {
        get
        {
            return this.dwhNaklIdField;
        }
        set
        {
            this.dwhNaklIdField = value;
        }
    }

    /// <remarks/>
    public byte doctypeId
    {
        get
        {
            return this.doctypeIdField;
        }
        set
        {
            this.doctypeIdField = value;
        }
    }

    /// <remarks/>
    public System.DateTime dateProved
    {
        get
        {
            return this.dateProvedField;
        }
        set
        {
            this.dateProvedField = value;
        }
    }

    /// <remarks/>
    public System.DateTime dateClient
    {
        get
        {
            return this.dateClientField;
        }
        set
        {
            this.dateClientField = value;
        }
    }

    /// <remarks/>
    public byte status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }

    /// <remarks/>
    public string sapCounter
    {
        get
        {
            return this.sapCounterField;
        }
        set
        {
            this.sapCounterField = value;
        }
    }

    /// <remarks/>
    public ulong contractNumber
    {
        get
        {
            return this.contractNumberField;
        }
        set
        {
            this.contractNumberField = value;
        }
    }

    /// <remarks/>
    public byte fromId
    {
        get
        {
            return this.fromIdField;
        }
        set
        {
            this.fromIdField = value;
        }
    }

    /// <remarks/>
    public byte storeId
    {
        get
        {
            return this.storeIdField;
        }
        set
        {
            this.storeIdField = value;
        }
    }

    /// <remarks/>
    public decimal sumNakl
    {
        get
        {
            return this.sumNaklField;
        }
        set
        {
            this.sumNaklField = value;
        }
    }

    /// <remarks/>
    public decimal sumNaklNoTax
    {
        get
        {
            return this.sumNaklNoTaxField;
        }
        set
        {
            this.sumNaklNoTaxField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NaklLines")]
    public NaklDtoNaklLines[] NaklLines
    {
        get
        {
            return this.naklLinesField;
        }
        set
        {
            this.naklLinesField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class NaklDtoNaklLines
{

    private ushort lagerIdField;

    private byte lineIdField;

    private ushort filIdField;

    private decimal kolvoField;

    private decimal priceInField;

    private decimal priceWithoutTaxField;

    private decimal sumTaxField;

    private decimal sumNoTaxField;

    private decimal mRPField;

    private decimal mRPBaseField;

    /// <remarks/>
    public ushort lagerId
    {
        get
        {
            return this.lagerIdField;
        }
        set
        {
            this.lagerIdField = value;
        }
    }

    /// <remarks/>
    public byte lineId
    {
        get
        {
            return this.lineIdField;
        }
        set
        {
            this.lineIdField = value;
        }
    }

    /// <remarks/>
    public ushort filId
    {
        get
        {
            return this.filIdField;
        }
        set
        {
            this.filIdField = value;
        }
    }

    /// <remarks/>
    public decimal kolvo
    {
        get
        {
            return this.kolvoField;
        }
        set
        {
            this.kolvoField = value;
        }
    }

    /// <remarks/>
    public decimal priceIn
    {
        get
        {
            return this.priceInField;
        }
        set
        {
            this.priceInField = value;
        }
    }

    /// <remarks/>
    public decimal priceWithoutTax
    {
        get
        {
            return this.priceWithoutTaxField;
        }
        set
        {
            this.priceWithoutTaxField = value;
        }
    }

    /// <remarks/>
    public decimal sumTax
    {
        get
        {
            return this.sumTaxField;
        }
        set
        {
            this.sumTaxField = value;
        }
    }

    /// <remarks/>
    public decimal sumNoTax
    {
        get
        {
            return this.sumNoTaxField;
        }
        set
        {
            this.sumNoTaxField = value;
        }
    }

    /// <remarks/>
    public decimal MRP
    {
        get
        {
            return this.mRPField;
        }
        set
        {
            this.mRPField = value;
        }
    }

    /// <remarks/>
    public decimal MRPBase
    {
        get
        {
            return this.mRPBaseField;
        }
        set
        {
            this.mRPBaseField = value;
        }
    }
}





