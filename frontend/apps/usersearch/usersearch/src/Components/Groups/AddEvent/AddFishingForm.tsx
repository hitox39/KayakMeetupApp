import { useState } from "react";

type FishingForumEvent = {
    EventName: string, 
}

async function addFishingEvents(id: FishingForumEvent) {
    var response = await fetch(`https://localhost:7062/api/fishingevent/`, {
        method : "POST"
    });

    if (!response.ok)
        throw new Error("Could not call the back end. ");

    const data = await response.json();
    return data;
}

export default function AddFishingForm() {
    const [eventName, setEventName] = useState("");
    const [cityName, setCityName] = useState("");
    const [zipCode, setZipCode] = useState("");
    const [address, setAddress] = useState("");
    const [country, setCountry] = useState("");

    return (
        <div>
            <form action="" method="post" className="Add Casual Event">
            <div className='grid md:grid-cols-2 gap-4 w-full py-2'>
                  <div className='flex flex-col'>
                    <label className='uppercase text-md py-2'>Race Name</label>
                    <input
                      className='border-2 rounded-lg p-3 flex border-gray-300'
                      type='text'
                      name='name'
                      onChange={ (e: React.ChangeEvent<HTMLInputElement> ) => setEventName(e.target.value) }
                    />
                  </div>
                  <div className='flex flex-col'>
                    <label className='uppercase text-md py-2'>City Name</label>
                    <input
                      className='border-2 rounded-lg p-3 flex border-gray-300'
                      type='text'
                      name='cityname'
                      onChange={ (e: React.ChangeEvent<HTMLInputElement> ) => setCityName(e.target.value) }
                    />
                  </div>
                </div>
                <div className='flex flex-col py-2'>
                  <label className='uppercase text-md py-2'>Zip Code</label>
                  <input
                    className='border-2 rounded-lg p-3 flex border-gray-300'
                    type='text'
                    name='zipcode'
                    onChange={ (e: React.ChangeEvent<HTMLInputElement> ) => setZipCode(e.target.value) }
                  />
                </div>
                <div className='flex flex-col py-2'>
                  <label className='uppercase text-md py-2'>Address</label>
                  <input
                    className='border-2 rounded-lg p-3 flex border-gray-300'
                    type='text'
                    name='address'
                    onChange={ (e: React.ChangeEvent<HTMLInputElement> ) => setAddress(e.target.value) }
                  />
                </div>
                <div className='flex flex-col py-2'>
                  <label className='uppercase text-md py-2'>Country</label>
                  <input
                    className='border-2 rounded-lg p-3 flex border-gray-300'
                    type='text'
                    name='country'
                    onChange={ (e: React.ChangeEvent<HTMLInputElement> ) => setCountry(e.target.value) }
                    />
                </div>
                <button className='bg-blue-400 w-[200px] rounded-md text-xl my-4 mx-auto py-3 text-black'>Submit Event</button>
            </form>
        </div>
    )
}