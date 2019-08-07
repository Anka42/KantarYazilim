[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(string PlakaNo, string Tartım_Kg, int DışTartım1, string p1, string MalzemeAdı, decimal BirimFiyatı, string p3, string SevkYeri, string OperatörAdı, string ŞoförAdı) {
            if ((PlakaNo == null)) {
                throw new global::System.ArgumentNullException("PlakaNo");
            }
            else {
                this.Adapter.InsertCommand.Parameters[0].Value = ((string)(PlakaNo));
            }
            if ((Tartım_Kg == null)) {
                throw new global::System.ArgumentNullException("Tartım_Kg");
            }
            else {
                this.Adapter.InsertCommand.Parameters[1].Value = ((string)(Tartım_Kg));
            }
            this.Adapter.InsertCommand.Parameters[2].Value = ((int)(DışTartım1));
            if ((p1 == null)) {
                throw new global::System.ArgumentNullException("p1");
            }
            else {
                this.Adapter.InsertCommand.Parameters[3].Value = ((string)(p1));
            }
            if ((MalzemeAdı == null)) {
                throw new global::System.ArgumentNullException("MalzemeAdı");
            }
            else {
                this.Adapter.InsertCommand.Parameters[4].Value = ((string)(MalzemeAdı));
            }
            this.Adapter.InsertCommand.Parameters[5].Value = ((decimal)(BirimFiyatı));
            if ((p3 == null)) {
                throw new global::System.ArgumentNullException("p3");
            }
            else {
                this.Adapter.InsertCommand.Parameters[6].Value = ((string)(p3));
            }
            if ((SevkYeri == null)) {
                throw new global::System.ArgumentNullException("SevkYeri");
            }
            else {
                this.Adapter.InsertCommand.Parameters[7].Value = ((string)(SevkYeri));
            }
            if ((OperatörAdı == null)) {
                throw new global::System.ArgumentNullException("OperatörAdı");
            }
            else {
                this.Adapter.InsertCommand.Parameters[8].Value = ((string)(OperatörAdı));
            }
            if ((ŞoförAdı == null)) {
                throw new global::System.ArgumentNullException("ŞoförAdı");
            }
            else {
                this.Adapter.InsertCommand.Parameters[9].Value = ((string)(ŞoförAdı));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.InsertCommand.Connection.Close();
                }