import CasualEvent from "./casualEvent";


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
    return (
        <div className="border-solid rounded-lg border-4 w-full border-black overflow-auto bg-slate-500 ">
            <form action="" method="post" className="Add Casual Event">
            <div className='grid md:grid-cols-2 gap-4 w-full py-2'>
                  <div className='flex flex-col'>
                    <label className='uppercase text-md py-2'>Race Name</label>
                    <input
                      className='border-2 rounded-lg p-3 flex border-gray-300'
                      type='text'
                      name='name'
                    />
                  </div>
                  <div className='flex flex-col'>
                    <label className='uppercase text-md py-2'>City Name</label>
                    <input
                      className='border-2 rounded-lg p-3 flex border-gray-300'
                      type='text'
                      name='cityname'
                    />
                  </div>
                </div>
                <div className='flex flex-col py-2'>
                  <label className='uppercase text-md py-2'>Zip Code</label>
                  <input
                    className='border-2 rounded-lg p-3 flex border-gray-300'
                    type='text'
                    name='zipcode'
                  />
                </div>
                <div className='flex flex-col py-2'>
                  <label className='uppercase text-md py-2'>Address</label>
                  <input
                    className='border-2 rounded-lg p-3 flex border-gray-300'
                    type='text'
                    name='address'
                  />
                </div>
                <div className='flex flex-col py-2'>
                  <label className='uppercase text-md py-2'>Country</label>
                  <input
                    className='border-2 rounded-lg p-3 flex border-gray-300'
                    type='text'
                    name='country'
                    />
                </div>
                <button className='bg-blue-400 w-[200px] rounded-md text-xl my-4 mx-auto py-3 text-black'>Submit Event</button>
            </form>
        </div>
    )
}
