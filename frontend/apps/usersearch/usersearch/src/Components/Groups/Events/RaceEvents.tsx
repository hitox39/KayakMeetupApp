import { useEffect, useState } from "react";
import State from "../../../Models/state";
import RaceEvent from '../AddEvent/raceEvent';


export default function RaceEvents() {

  const [raceEvent, setRaceEvent] = useState<RaceEvent>({
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
      var response = await fetch(`https://localhost:7062/api/fishingevent/db9e7f20-b390-450c-a171-8b28b15bdbea`, {
        method: "GET"
      });

      const data: RaceEvent = await response.json();
      console.log(data);
      setRaceEvent(data);
    };
    dataFetch();

  }, []);

  return (
    <div className='w-full my-32'>
      <div className='max-w-[1240px] mx-auto px-2'>
        <h2 className='text-5xl font-bold text-center'>Fishing Events</h2>


        <div className=''>
          <div className='flex'>
            <table className="table-auto">
              <thead>
                <tr >
                  <th>ID</th>
                  <th className=''>Event Name</th>
                  <th className=''> Address</th>
                  <th className=''>City Name</th>
                  <th className=''>State</th>
                  <th className=''>Zip Code</th>
                  <th>Country</th>
                </tr>
              </thead>
              <tbody>
                <tr >
                  <td>{raceEvent.id}</td>
                  <td>{raceEvent.eventName}</td>
                  <td>{raceEvent.address}</td>
                  <td>{raceEvent.cityName}</td>
                  <td>{raceEvent.state}</td>
                  <td>{raceEvent.zipCode}</td>
                  <td>{raceEvent.country}</td>
                </tr>
              </tbody>
            </table>
          </div>
        </div>
      </div>
    </div>
  );

}



