﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppWindows_Colegio.ProxyDocente {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DocenteBE", Namespace="http://schemas.datacontract.org/2004/07/WCF_Colegio")]
    [System.SerializableAttribute()]
    public partial class DocenteBE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DNI1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Direccion1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaNacField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Fecha_regiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Fecha_ult_modField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Grado_estudioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Id_Curso1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Id_Docente1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool Mvaract_docField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Mvarid_distritroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Mvarnombre_distritoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombresApellidosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Numero_tel1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SexoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Usu_ult_modField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Valor_codigoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Apellidos {
            get {
                return this.ApellidosField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidosField, value) != true)) {
                    this.ApellidosField = value;
                    this.RaisePropertyChanged("Apellidos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoField, value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DNI1 {
            get {
                return this.DNI1Field;
            }
            set {
                if ((object.ReferenceEquals(this.DNI1Field, value) != true)) {
                    this.DNI1Field = value;
                    this.RaisePropertyChanged("DNI1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Direccion1 {
            get {
                return this.Direccion1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Direccion1Field, value) != true)) {
                    this.Direccion1Field = value;
                    this.RaisePropertyChanged("Direccion1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaNac {
            get {
                return this.FechaNacField;
            }
            set {
                if ((this.FechaNacField.Equals(value) != true)) {
                    this.FechaNacField = value;
                    this.RaisePropertyChanged("FechaNac");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fecha_regi {
            get {
                return this.Fecha_regiField;
            }
            set {
                if ((this.Fecha_regiField.Equals(value) != true)) {
                    this.Fecha_regiField = value;
                    this.RaisePropertyChanged("Fecha_regi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fecha_ult_mod {
            get {
                return this.Fecha_ult_modField;
            }
            set {
                if ((this.Fecha_ult_modField.Equals(value) != true)) {
                    this.Fecha_ult_modField = value;
                    this.RaisePropertyChanged("Fecha_ult_mod");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Grado_estudio {
            get {
                return this.Grado_estudioField;
            }
            set {
                if ((object.ReferenceEquals(this.Grado_estudioField, value) != true)) {
                    this.Grado_estudioField = value;
                    this.RaisePropertyChanged("Grado_estudio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id_Curso1 {
            get {
                return this.Id_Curso1Field;
            }
            set {
                if ((this.Id_Curso1Field.Equals(value) != true)) {
                    this.Id_Curso1Field = value;
                    this.RaisePropertyChanged("Id_Curso1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id_Docente1 {
            get {
                return this.Id_Docente1Field;
            }
            set {
                if ((this.Id_Docente1Field.Equals(value) != true)) {
                    this.Id_Docente1Field = value;
                    this.RaisePropertyChanged("Id_Docente1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Mvaract_doc {
            get {
                return this.Mvaract_docField;
            }
            set {
                if ((this.Mvaract_docField.Equals(value) != true)) {
                    this.Mvaract_docField = value;
                    this.RaisePropertyChanged("Mvaract_doc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Mvarid_distritro {
            get {
                return this.Mvarid_distritroField;
            }
            set {
                if ((this.Mvarid_distritroField.Equals(value) != true)) {
                    this.Mvarid_distritroField = value;
                    this.RaisePropertyChanged("Mvarid_distritro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mvarnombre_distrito {
            get {
                return this.Mvarnombre_distritoField;
            }
            set {
                if ((object.ReferenceEquals(this.Mvarnombre_distritoField, value) != true)) {
                    this.Mvarnombre_distritoField = value;
                    this.RaisePropertyChanged("Mvarnombre_distrito");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombres {
            get {
                return this.NombresField;
            }
            set {
                if ((object.ReferenceEquals(this.NombresField, value) != true)) {
                    this.NombresField = value;
                    this.RaisePropertyChanged("Nombres");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombresApellidos {
            get {
                return this.NombresApellidosField;
            }
            set {
                if ((object.ReferenceEquals(this.NombresApellidosField, value) != true)) {
                    this.NombresApellidosField = value;
                    this.RaisePropertyChanged("NombresApellidos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Numero_tel1 {
            get {
                return this.Numero_tel1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Numero_tel1Field, value) != true)) {
                    this.Numero_tel1Field = value;
                    this.RaisePropertyChanged("Numero_tel1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sexo {
            get {
                return this.SexoField;
            }
            set {
                if ((object.ReferenceEquals(this.SexoField, value) != true)) {
                    this.SexoField = value;
                    this.RaisePropertyChanged("Sexo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Usu_ult_mod {
            get {
                return this.Usu_ult_modField;
            }
            set {
                if ((object.ReferenceEquals(this.Usu_ult_modField, value) != true)) {
                    this.Usu_ult_modField = value;
                    this.RaisePropertyChanged("Usu_ult_mod");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Valor_codigo {
            get {
                return this.Valor_codigoField;
            }
            set {
                if ((this.Valor_codigoField.Equals(value) != true)) {
                    this.Valor_codigoField = value;
                    this.RaisePropertyChanged("Valor_codigo");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyDocente.IServicioDocente")]
    public interface IServicioDocente {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDocente/GetAllDocentes", ReplyAction="http://tempuri.org/IServicioDocente/GetAllDocentesResponse")]
        AppWindows_Colegio.ProxyDocente.DocenteBE[] GetAllDocentes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDocente/GetAllDocentes", ReplyAction="http://tempuri.org/IServicioDocente/GetAllDocentesResponse")]
        System.Threading.Tasks.Task<AppWindows_Colegio.ProxyDocente.DocenteBE[]> GetAllDocentesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDocente/GetDocente", ReplyAction="http://tempuri.org/IServicioDocente/GetDocenteResponse")]
        AppWindows_Colegio.ProxyDocente.DocenteBE GetDocente(int strId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDocente/GetDocente", ReplyAction="http://tempuri.org/IServicioDocente/GetDocenteResponse")]
        System.Threading.Tasks.Task<AppWindows_Colegio.ProxyDocente.DocenteBE> GetDocenteAsync(int strId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDocente/InsertDocente", ReplyAction="http://tempuri.org/IServicioDocente/InsertDocenteResponse")]
        bool InsertDocente(AppWindows_Colegio.ProxyDocente.DocenteBE objDocenteBE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDocente/InsertDocente", ReplyAction="http://tempuri.org/IServicioDocente/InsertDocenteResponse")]
        System.Threading.Tasks.Task<bool> InsertDocenteAsync(AppWindows_Colegio.ProxyDocente.DocenteBE objDocenteBE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDocente/UpdateDocente", ReplyAction="http://tempuri.org/IServicioDocente/UpdateDocenteResponse")]
        bool UpdateDocente(AppWindows_Colegio.ProxyDocente.DocenteBE objDocenteBE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDocente/UpdateDocente", ReplyAction="http://tempuri.org/IServicioDocente/UpdateDocenteResponse")]
        System.Threading.Tasks.Task<bool> UpdateDocenteAsync(AppWindows_Colegio.ProxyDocente.DocenteBE objDocenteBE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDocente/DeleteDocente", ReplyAction="http://tempuri.org/IServicioDocente/DeleteDocenteResponse")]
        bool DeleteDocente(int strCod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDocente/DeleteDocente", ReplyAction="http://tempuri.org/IServicioDocente/DeleteDocenteResponse")]
        System.Threading.Tasks.Task<bool> DeleteDocenteAsync(int strCod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDocente/BuscarDocentes", ReplyAction="http://tempuri.org/IServicioDocente/BuscarDocentesResponse")]
        AppWindows_Colegio.ProxyDocente.DocenteBE[] BuscarDocentes(string ape);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDocente/BuscarDocentes", ReplyAction="http://tempuri.org/IServicioDocente/BuscarDocentesResponse")]
        System.Threading.Tasks.Task<AppWindows_Colegio.ProxyDocente.DocenteBE[]> BuscarDocentesAsync(string ape);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioDocenteChannel : AppWindows_Colegio.ProxyDocente.IServicioDocente, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioDocenteClient : System.ServiceModel.ClientBase<AppWindows_Colegio.ProxyDocente.IServicioDocente>, AppWindows_Colegio.ProxyDocente.IServicioDocente {
        
        public ServicioDocenteClient() {
        }
        
        public ServicioDocenteClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioDocenteClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioDocenteClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioDocenteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AppWindows_Colegio.ProxyDocente.DocenteBE[] GetAllDocentes() {
            return base.Channel.GetAllDocentes();
        }
        
        public System.Threading.Tasks.Task<AppWindows_Colegio.ProxyDocente.DocenteBE[]> GetAllDocentesAsync() {
            return base.Channel.GetAllDocentesAsync();
        }
        
        public AppWindows_Colegio.ProxyDocente.DocenteBE GetDocente(int strId) {
            return base.Channel.GetDocente(strId);
        }
        
        public System.Threading.Tasks.Task<AppWindows_Colegio.ProxyDocente.DocenteBE> GetDocenteAsync(int strId) {
            return base.Channel.GetDocenteAsync(strId);
        }
        
        public bool InsertDocente(AppWindows_Colegio.ProxyDocente.DocenteBE objDocenteBE) {
            return base.Channel.InsertDocente(objDocenteBE);
        }
        
        public System.Threading.Tasks.Task<bool> InsertDocenteAsync(AppWindows_Colegio.ProxyDocente.DocenteBE objDocenteBE) {
            return base.Channel.InsertDocenteAsync(objDocenteBE);
        }
        
        public bool UpdateDocente(AppWindows_Colegio.ProxyDocente.DocenteBE objDocenteBE) {
            return base.Channel.UpdateDocente(objDocenteBE);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateDocenteAsync(AppWindows_Colegio.ProxyDocente.DocenteBE objDocenteBE) {
            return base.Channel.UpdateDocenteAsync(objDocenteBE);
        }
        
        public bool DeleteDocente(int strCod) {
            return base.Channel.DeleteDocente(strCod);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteDocenteAsync(int strCod) {
            return base.Channel.DeleteDocenteAsync(strCod);
        }
        
        public AppWindows_Colegio.ProxyDocente.DocenteBE[] BuscarDocentes(string ape) {
            return base.Channel.BuscarDocentes(ape);
        }
        
        public System.Threading.Tasks.Task<AppWindows_Colegio.ProxyDocente.DocenteBE[]> BuscarDocentesAsync(string ape) {
            return base.Channel.BuscarDocentesAsync(ape);
        }
    }
}
