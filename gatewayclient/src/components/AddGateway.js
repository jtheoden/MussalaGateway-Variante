import React from 'react';

import axios from 'axios';

export default class AddGateway extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
                name: '',
                serial:'',
                ip:''
        };
        this.changeNameHandler=this.changeHandler.bind(this);
   
        this.submitHandler = this.submitHandler.bind(this);
    }


    changeHandler(e)  {
        this.setState({
            name: e.target.value,
            serial: e.target.value,
            ip: e.target.value
        });
    }

    submitHandler(h) {
        h.preventDefault();
        var gatewayName=this.state.name;
        var gatewaySerial=this.state.serial;
        var gatewayIP=this.state.ip;
        if(!gatewayName || !gatewaySerial || !gatewayIP){
            return;
        }
        console.log(gatewayName);
        console.log(gatewaySerial);
        console.log(gatewayIP);
        var data = new FormData();
        data.append("name",gatewayName);
        data.append("serial", gatewaySerial);
        data.append("ip",gatewayIP);
        axios({
            method:'post',
            url:'http://localhost:5000/gateways',
            data: data,
        })
        .then((res)=>{
            console.log(res.data);
        })
        .catch((err)=>{throw err});
        this.setState({name:"",serial:"", ip:"" });
    }


    render() {

        return (
            <>
                <form onSubmit={this.submitHandler}>
                    <div className="form-group row">
                        <div className="col-sm-3"><input type="text" required className="form-control justify-content-start " name="name" id="name"  placeholder="Gateway Name"  onChange={"this.changeHandler"} /></div>
                        <div className="col-sm-3"><input type="text" required className="form-control justify-content-start " name="serial"  placeholder="Serial Number"   onChange={"this.changeHandler"}/></div>
                        <div className="col-sm-3"><input type="text" pattern="^(?:(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9]?[0-9])(\.(?!$)|$)){4}$" required  className="form-control justify-content-start " name="ip"  placeholder="Ipv4 Address"   onChange={"this.changeHandler"}/></div>
                        <div className="col-sm-3"><button type="submit" className="btn btn-success justify-content-start " >Add New Gateway</button></div>
                    </div>
                </form>
            </>
        );
    }
}

