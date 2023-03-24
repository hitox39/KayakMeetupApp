import { useState } from "react";
import AddCasual from "../AddEvent/AddCasualForm";
import AddFishing from "../AddEvent/AddFishingForm";
import AddRaceForm from "../AddEvent/AddRaceForm";

export default function FindEvents() {

    const [showForm, setShowForm] = useState(false);
    const [eventType, setEventType] = useState("");

    function handleShowForm(e: React.ChangeEvent<HTMLSelectElement>) {

        if (e.currentTarget.value === "") {
            setEventType("");
            setShowForm(false);
            return;
        }
        setShowForm(true);
        setEventType(e.currentTarget.value);
    }


    return (
        <div>
            <div className="bg-fixed bg-center bg-cover custom-img">
                <div className='max-w-[1240px] mx-auto grid md:grid-cols-2 gap-8 '>
                    <div className='w-100  shadow-xl bg-gray-100 flex flex-col p-4 my-1 rounded-lg hover:scale-125 duration-300'>
                        <label htmlFor="event-select">Select an Event:</label>
                        <select name="events" id="events-select" onChange={handleShowForm}>
                            <option value="">--Please choose an option--</option>
                            <option value="casualevent">Casual Event</option>
                            <option value="fishingevent">Fishing Event</option>
                            <option value="raceevent">Race Event</option>
                        </select>
                        <h2 className='text-3xl font-bold text-center py-8'></h2>
                        <div className='text-center font-medium'>
                            <p className='py-2 border-b mx-8 mt-8'></p>
                        </div>
                        <button className='bg-[#00df9a] w-[200px] text-black rounded-md font-medium my-6 mx-auto px-6 py-3'>Find Event</button>
                    </div>
                    <div className='w-full shadow-xl bg-gray-100 flex flex-col p-4 my-1 rounded-lg hover:scale-125 duration-300'>
                        <label htmlFor="event-select">Select an Event:</label>
                        <select name="events" id="events-select" onChange={handleShowForm}>
                            <option value="">--Please choose an option--</option>
                            <option value="casualevent">Casual Event</option>
                            <option value="fishingevent">Fishing Event</option>
                            <option value="raceevent">Race Event</option>
                        </select>
                        <h2 className='text-3xl font-bold text-center py-8'></h2>
                        <div className='text-center font-medium'>
                            <p className='py-2 border-b mx-8 mt-8'></p>
                        </div>
                        {eventType === "raceevent" && showForm && <AddRaceForm />}
                        {eventType === "fishingevent" && showForm && <AddFishing />}
                        {eventType === "casualevent" && showForm && <AddCasual />}
                        <button className='bg-[#00df9a] w-[200px] text-black rounded-md font-medium my-6 mx-auto px-6 py-3'>Make Event</button>
                    </div>
                </div>
            </div>
        </div>
    )
}