import { useState } from "react";
import AddCasual from "./AddCasualForm";
import AddFishing from "./AddFishingForm";
import AddRaceForm from "./AddRaceForm";

export default function AddEvents() {

    const [showForm, setShowForm] = useState<boolean>(false);
    const [eventType, setEventType] = useState("");

    function handleShowForm(e: React.ChangeEvent<HTMLSelectElement>){

        if (e.currentTarget.value === "" ){
            setEventType("");
            setShowForm(false);
            return;
        }
        setShowForm(true);
        setEventType(e.currentTarget.value);
    }


    return (
        <div>
            <label htmlFor="event-select">Choose an Event:</label>

            <select name="events" id="events-select" onChange={handleShowForm}>
                <option value="">--Please choose an option--</option>
                <option value="casualevent">Casual Event</option>
                <option value="fishingevent">Fishing Event</option>
                <option value="raceevent">Race Event</option>
            </select>
            {eventType === "raceevent" && showForm && <AddRaceForm />}
            {eventType === "fishingevent" && showForm && <AddFishing />}
            {eventType === "casualevent" && showForm && <AddCasual />}
        </div>


    )
}