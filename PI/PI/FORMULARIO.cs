//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PI
{
    using System;
    using System.Collections.Generic;
    
    public partial class FORMULARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FORMULARIO()
        {
            this.CONSULTAs = new HashSet<CONSULTA>();
        }
    
        public int ID_FORMULARIO { get; set; }
        public string PATOLODIA_DE_BASE { get; set; }
        public string CIRURGIAS_ANTERIORES { get; set; }
        public string TABAGISMO { get; set; }
        public string ETILISMO { get; set; }
        public string HISTORICO_DE_ALERGIA { get; set; }
        public string MEDICAMENTO_ATUAL { get; set; }
        public double PESO { get; set; }
        public double ALTURA { get; set; }
        public double IMC { get; set; }
        public string APITITE_USUAL { get; set; }
        public string PERDA_DE_PESO { get; set; }
        public string TURGO_DE_PELE { get; set; }
        public string ELIMINACAO_FEZES { get; set; }
        public string SONO_SATISFATORIO { get; set; }
        public string USA_SONIFERO { get; set; }
        public string VIDA_SEXUAL { get; set; }
        public string FERIDA_INTERFERE { get; set; }
        public string AJ_TOMAR_BANHO { get; set; }
        public string AJ_VERTIRSE { get; set; }
        public string AJ_IR_BANHEIRO { get; set; }
        public string AJ_SENTAR_LEVANTAR { get; set; }
        public string AJ_PREPARO_REFEICAO { get; set; }
        public string AJ_TAREFA_DOMESTICA { get; set; }
        public string AJ_LAVAR_ROUPA { get; set; }
        public string AJ_DEAMBULAR { get; set; }
        public string AJ_USO_MEIO_DE_TRANSPORTE { get; set; }
        public string FORCA_MOTORA { get; set; }
        public string PARALISIA { get; set; }
        public string PARESTESIA { get; set; }
        public string DEPEDENCIA_AUTOCUIDADO { get; set; }
        public string HIGIENE_CORPORAL { get; set; }
        public string APR_MMII { get; set; }
        public string APR_TRAUMA { get; set; }
        public string PQ_LESAO_PERNA_D { get; set; }
        public string PQ_LESA0_PERNA_E { get; set; }
        public string CONDICAO_PELE_UCERA { get; set; }
        public string CLASSIFICACAO_FERIDA { get; set; }
        public string CARACTERISTICA_LESAO { get; set; }
        public string ODOR { get; set; }
        public string EXSUDATO { get; set; }
        public string GRANULACAO { get; set; }
        public string ESFACELO { get; set; }
        public string ESCARA { get; set; }
        public string CONDICOES_BORDA { get; set; }
        public string TAMANHO_LESAO { get; set; }
        public string REGULACAO_TERMICA { get; set; }
        public string REGULACAO_NEUROLOGICA { get; set; }
        public string NIVEL_CONCIENCIA { get; set; }
        public string REGULACAO_IMUNOLOGICA { get; set; }
        public string VACINACAO { get; set; }
        public string PRECAO_ARTERIAL { get; set; }
        public string PRESENCA_EMATOMAS { get; set; }
        public string EDEMA_MMII { get; set; }
        public string PULSO_PAPAVEIS { get; set; }
        public string PERCEPCAO_DOLOROSA { get; set; }
        public string FATORES_DOR { get; set; }
        public string FATORES_AUMETA_DOR { get; set; }
        public string AGUA_TRATADA { get; set; }
        public string COLETA_LIXO { get; set; }
        public string SENEAMENTO_BASICO { get; set; }
        public string ANIMAIS_DOMESTICO { get; set; }
        public string COBERTURA_PRIMARIAS { get; set; }
        public string CURATIVO_SOZINHO { get; set; }
        public string AUTOMEDITACAO { get; set; }
        public string CORBETURA_SEM_PRESCRICAO { get; set; }
        public string EXPLICAR_AP_UCERA { get; set; }
        public string SABE_COMO_PREVINIR_LESOES { get; set; }
        public string FOTORES_PRE_CICATRIZACAO { get; set; }
        public string SEN_TRITEZA { get; set; }
        public string SEN_RAIVA { get; set; }
        public string SENT_ANSIEDADE { get; set; }
        public string SENT_CONTRARIEDADE { get; set; }
        public string SENT_TRAQUILIDADE { get; set; }
        public string SENT_DESMOTIVACAO { get; set; }
        public int VALORES_MSD { get; set; }
        public int MSE { get; set; }
        public int MID { get; set; }
        public int MIE { get; set; }
        public int CAL_ITB { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONSULTA> CONSULTAs { get; set; }
    }
}
