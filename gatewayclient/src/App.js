import logo from './logo.svg';
import './App.css';
import gear from './gear.svg'
import React, {useState,useEffect}from 'react';
import './bootstrap.css';
import axios from 'axios';
import AddGateway from './components/AddGateway'


class App extends React.Component
{
  render(){
    
    return(
      <>
        <div className="App">
        <header className="App-header">
        <h1>Mussala Gateways</h1><img src={logo} className="" alt="logo" width="120"/>
        <p>
          Gateway Control and attached devices...
        </p>
        <div>
        <AddGateway/>
        <GatewayList  />
        </div>
    </header>
        </div>
    </>
    )
  }
}

function GatewayList(){
    const  baseURL ="http://localhost:5000/gatewayclient/"
    const [data,setdata]=useState([])
    const [devices,setdevices]=useState([])
    const peticionesGET=async()=>{
      await axios.get(baseURL+"gateways").then(response=>{
        setdata(response.data);
      }).catch(error=>{console.log(error);
         axios.get(baseURL+"gateways/"+selectedGAteway.id+"/devices").then(response=>{
          setdevices(response.devices);}).catch(error=>{console.log(error);})
    })
  }
  useEffect(
    ()=>{peticionesGET();},[]);

   
  const [selectedGAteway,setSelectedGAteway]=useState({
    id: '',
    humanReadableName: '',
    serialNumber:'',
    iPv4Address:'',
    pdevices:'',
  })
  const [selectedGAtewayDevices,setSelectedGAtewayDevices]=useState({
    id: '',
    vendor: '',
    status:'',
    photo:''

  })
  const peticionesPOST=async()=>{
  axios.post(baseURL+'gateways/', selectedGAteway)
            .then(response => this.setState({ articleId: response.data.id }));
  }


  const handleChange=e=>{
    const {name,value}=e.target;
    setSelectedGAteway({
      selectedGAteway,
      [name]:value
    });
  }

    return (
      <>
        
        <br />

      <div id="carouselExampleControls" class="carousel slide dark" data-bs-ride="carousel">
        <div class="carousel-inner">
          {
            data.length===0
            ? <img src={gear} className="App-logo" alt="logo" width="120"/>+'Loading gateways...'
            : data.map(gateway=> <Gateway nombre={gateway.humanReadableName} serial={gateway.serialNumber} ip={gateway.iPv4Address} key={gateway.id} pdevices={devices} />)}
        </div>

      </div>
      </>
    );
}

export class Gateway extends React.Component
{
  constructor(props) {
    super(props);

    this.state = { 
        status: null
    };
}
  deleteGateway()
  {
   axios.delete("http://localhost:5000/gatewayclient/gateways/"+this.props.key)
   ;
  }
  componentDidMount() {
  }
  render()
  {
    
return (
  <div className="btn btn-dark">
    <div class="carousel-item active">
      <div className="Gateway" >
        <div class="card" ><form action="" className="align-self-end"><button className="btn btn-danger " onClick={this.deleteGateway}>X</button></form>
          <div className="card-body transparent text-dark">
            <h5 className="card-title ">{this.props.nombre}</h5>
            <p className="card-text">{this.props.serial}</p>
            <p>{this.props.ip}</p>
            <p>
            {
              this.props.pdevices.map(dev=>{
                <button className="btn btn-warning" onClick={"()=>peticionesDevicesGET()"}>
                  <div>
                    <img src={dev.photo}   alt="" /><br/> <h5>{dev.vendor}</h5><br /><small>{dev.status}</small>
                  </div>
                </button>
              })

            }
                
            </p>
          </div>
        </div>
      </div>
    </div>

  </div>
    );
  }
}






export default App;
