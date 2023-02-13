type RaceEvent = {
    EventName: string, 
}

async function addRaceEvents(id: RaceEvent) {
    var response = await fetch(`https://localhost:7062/api/raceevent/`, {
        method : "POST"
    });

    if (!response.ok)
        throw new Error("Could not call the back end. ");

    const data = await response.json();
    return data;
}

export default function AddRaceForm() {
    return (
        <div>
            <form action="" method="post" className="Add Race">
                <div className="racename">
                    <label htmlFor="RaceName">Race Name Name: </label>
                    <input type="text" name="RaceName" id="racename" required />
                </div>
                <div className="cityname">
                    <label htmlFor="cityname">City Name: </label>
                    <input type="text" name="cityName" id="cityname" required />
                </div>
                <div className="state">
                    <label htmlFor="name">State: </label>
                    <input type="text" name="name" id="name" required />
                </div>
                <div className="zipcode">
                    <label htmlFor="email">Zip Code: </label>
                    <input type="text" name="email" id="email" required />
                </div>
                <div className="address">
                    <label htmlFor="address">Address: </label>
                    <input type="text" name="name" id="name" required />
                </div>
                <div className="country">
                    <label htmlFor="country">Country: </label>
                    <input type="text" name="country" id="country" required />
                </div>
                <div className="prizepool">
                    <label htmlFor="prizepool">Prizepool: </label>
                    <input type="text" name="prizepool" id="prizepool" required />
                </div>
                <div className="submit">
                    <input type="submit" value="Submit!" />
                </div>
            </form>
        </div>
    )
}