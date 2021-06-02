import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import 'bootstrap/dist/css/bootstrap.min.css';




import App from './App';
import reportWebVitals from './reportWebVitals';

ReactDOM.render(

    <App />
    ,
  document.getElementById('root')
);
/*
function TimeArea(){
  const [thetime,settime]=useState(new Date().toLocaleString())
  setTimeout(function(){
    settime(new Date().toLocaleString())
  },1000)
  return <p>Current Time is: {thetime}</p>
}*/

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
