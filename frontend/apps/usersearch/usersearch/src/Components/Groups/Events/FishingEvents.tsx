import { useEffect, useState } from "react";
import State from "../../../Models/state";
import FishingEvent from '../AddEvent/fishingEvent';


export default function FishingEvents() {

  const [fishingEvent, setFishingEvent] = useState<FishingEvent>({
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

      const data: FishingEvent = await response.json();
      console.log(data);
      setFishingEvent(data);
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
                  <td>{fishingEvent.id}</td>
                  <td>{fishingEvent.eventName}</td>
                  <td>{fishingEvent.address}</td>
                  <td>{fishingEvent.cityName}</td>
                  <td>{fishingEvent.state}</td>
                  <td>{fishingEvent.zipCode}</td>
                  <td>{fishingEvent.country}</td>
                </tr>
              </tbody>
            </table>
          </div>
        </div>
      </div>
    </div>
  );

}



