import React, { useEffect, useState } from 'react';
import State from '../../../Models/state';
import CasualEvent from '../AddEvent/casualEvent';

export default function CasualEvents() {

  const [casualEvent, setCasualEvent] = useState<CasualEvent>({
    address: "",
    cityName: "",
    country: "",
    eventName: "",
    state: State.None,
    id: "",
    zipCode: "",
  });

  useEffect(() => {
    const dataFetch = async () => {
      var response = await fetch(`https://localhost:7062/api/casualevent/4d5bea51-b11e-45a0-b23d-e30038ba771a`, {
        method: "GET"
      });

      const data: CasualEvent = await response.json();
      console.log(data);
      setCasualEvent(data);
    };
    dataFetch();

  }, []);



  return (
    <div>
      <h3 className='text-center '
      >Casual Events</h3>

      <table className="border-solid rounded border-4 border-black overflow-auto"
        bgcolor="grey" width="900">
        <thead>
          <tr >
            <th>ID</th>
            <th>Event Name</th>
            <th>Address</th>
            <th>City Name</th>
            <th>State</th>
            <th>Zip Code</th>
            <th>Country</th>
          </tr>
        </thead>
        <tbody>
          <tr >
            <td>{casualEvent.id}</td>
            <td>{casualEvent.eventName}</td>
            <td>{casualEvent.address}</td>
            <td>{casualEvent.cityName}</td>
            <td>{casualEvent.state}</td>
            <td>{casualEvent.zipCode}</td>
            <td>{casualEvent.country}</td>
          </tr>
        </tbody>
      </table>
    </div>
  );
}