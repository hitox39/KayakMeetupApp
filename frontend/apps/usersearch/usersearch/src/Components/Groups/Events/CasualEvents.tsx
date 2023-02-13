import React from 'react';
import CasualEvent from '../AddEvent/casualEvent';


async function getCasualEvents(id: string) {
  var response = await fetch(`https://localhost:5173/casualevents/8082F9DB-BA24-49FC-9BA8-B460DBCFDB76`, {
    method: "GET"
  });

  const data: CasualEvent = await response.json();


  return (
    <tr >
      <td>{data.id}</td>
      <td>{data.eventName}</td>
      <td>{data.address}</td>
      <td>{data.city}</td>
      <td>{data.state}</td>
      <td>{data.zipCode}</td>
      <td>{data.country}</td>
    </tr>
  );
}

export default function CasualEvents() {

  async function getCasualEvents(id: string) {
    var response = await fetch(`https://localhost:5173/casualevents/8082F9DB-BA24-49FC-9BA8-B460DBCFDB76`, {
      method: "GET"
    });
  
    const data: CasualEvent = await response.json();
  
  
    return (
      <tr >
        <td>{data.id}</td>
        <td>{data.eventName}</td>
        <td>{data.address}</td>
        <td>{data.city}</td>
        <td>{data.state}</td>
        <td>{data.zipCode}</td>
        <td>{data.country}</td>
      </tr>
    );
  }
  return (
    <html>
      <body>

        <h3 className='text-center '
        >Casual Events</h3>

        <table className="border-solid rounded border-4 border-black overflow-auto"
          bgcolor="grey" width="900">
          <tr >
            <th>Event Name</th>
            <th>City Name</th>
            <th>State</th>
            <th>Zip Code</th>
            <th>Address</th>
            <th>Country</th>
          </tr>
          <tr >
           {getCasualEvents("")}
          </tr>
        </table>
      </body>
    </html>
  );
}