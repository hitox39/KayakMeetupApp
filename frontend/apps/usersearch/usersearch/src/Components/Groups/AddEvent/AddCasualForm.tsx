import CasualEvent from "./casualEvent";
import React, { useState } from "react";


async function addCasualEvents(id: CasualEvent) {
    var response = await fetch(`https://localhost:7062/api/casualevent/`, {
        method : "POST"
    });

    if (!response.ok)
        throw new Error("Could not call the back end. ");

    const data = await response.json();
    return data;
}

export default function AddCasualForm() {
    const [raceName, setRaceName] = useState("");
    const [cityName, setCityName] = useState("");
    const [zipCode, setZipCode] = useState("");
    const [address, setAddress] = useState("");
    const [country, setCountry] = useState("");

    return (
      <div className='bg-fixed bg-center bg-cover custom-img '>
        <div className="border-solid rounded-lg border-4 w-3/5  border-[#00df9a] overflow-auto bg-black text-[#00df9a] mx-auto text-left p flex flex-col justify-center  ">
            <form action="" method="post" className="Add Casual Event">
            <div className='grid md:grid-cols-2 gap-4 w-full py-2 '>
                  <div className='flex flex-col'>
                    <label className='uppercase text-md py-2 ml-6'>Race Name</label>
                    <input
                      className='border-2 rounded-lg p-3 flex border-gray-300 mx-4'
                      type='text'
                      name='name'
                      onChange={ (e: React.ChangeEvent<HTMLInputElement> ) => setRaceName(e.target.value) }
                    />
                  </div>
                  <div className='flex flex-col'>
                    <label className='uppercase text-md py-2 ml-6'>City Name</label>
                    <input
                      className='border-2 rounded-lg p-3 flex border-gray-300 mx-4'
                      type='text'
                      name='cityname'
                      onChange={ (e: React.ChangeEvent<HTMLInputElement> ) => setCityName(e.target.value) }
                    />
                  </div>
                  <div className='flex flex-col '>
                  <label className='uppercase text-md py-2 ml-6'>Zip Code</label>
                  <input
                    className='border-2 rounded-lg p-3 flex border-gray-300 mx-4'
                    type='text'
                    name='zipcode'
                    onChange={ (e: React.ChangeEvent<HTMLInputElement> ) => setZipCode(e.target.value) }
                  />
                </div>
                  <div className='flex flex-col '>
                  <label className='uppercase text-md py-2 ml-6'>Country</label>
                  <input
                    className='border-2 rounded-lg p-3 flex border-gray-300 mx-4'
                    type='text'
                    name='country'
                    onChange={ (e: React.ChangeEvent<HTMLInputElement> ) => setCountry(e.target.value) }
                    />
                </div>
                </div>
                
                <div className='flex flex-col '>
                  <label className='uppercase text-md py-2 ml-6'>Address</label>
                  <input
                    className='border-2 rounded-lg p-3 flex border-gray-300 mx-4'
                    type='text'
                    name='address'
                    onChange={ (e: React.ChangeEvent<HTMLInputElement> ) => setAddress(e.target.value) }
                  />
                </div>
                
                <button className='bg-[#00df9a] ml-6 w-[200px] rounded-md text-xl my-4 mx-auto py-3 text-black'>Submit Event</button>
            </form>
        </div>
        </div>
    )
}
