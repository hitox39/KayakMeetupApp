import { useState } from "react";
import { Link } from "react-router-dom";


const Sidebar = () => {
    const [toggleMenu, setToggleMenu] = useState(false);

    return (
        <nav className="bg-[#00df9a] font-bold text-xl w-1/6 h-screen">
          <ul >
            <li ><Link to="/">Home</Link></li>
            <li ><Link to="/casualevents">Find Casual Events</Link></li>
            <li ><Link to="/fishingevents">Find Fishing Events</Link></li>
            <li ><Link to="/raceevents">Find Race Events</Link></li>
            <li ><Link to="/addevents">Add Events</Link></li>
          </ul>
        </nav>
      );   


}

export default  Sidebar;