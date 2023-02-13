

export default function FindEvents() {
    return (
        <div>
            <label htmlFor="event-select">Select an Event:</label>

            <select name="events" id="events-select">
                <option value="">--Please choose an option--</option>
                <option value="casualevent">Casual Event</option>
                <option value="fishingevent">Fishing Event</option>
                <option value="raceevent">Race Event</option>
            </select>
        </div>


    )
}