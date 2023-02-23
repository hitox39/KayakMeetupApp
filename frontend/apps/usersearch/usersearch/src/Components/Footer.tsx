import {
    FaPinterest,
    FaFacebookSquare,
    FaGithubSquare,
    FaInstagram,
    FaTwitterSquare,
    FaYoutube,
} from 'react-icons/fa';

const Footer = () => {
    return (
        <div className='max-w-[1240px] mx-auto py-16 px-10 grid lg:grid-cols-3 gap-10 text-gray-500'>
            <div>
                <h1 className='w-full text-3xl font-bold text-red-400'>ANNIES'S BAKERY.</h1>
                <div className='flex justify-between md:w-[75%] my-6'>
                    <FaFacebookSquare size={30} />
                    <FaInstagram size={30} />
                    <FaTwitterSquare size={30} />
                    <FaGithubSquare size={30} />
                    <FaPinterest size={30} />
                    <FaYoutube size={30} />
                </div>
            </div>
            <div className='lg:col-span-2 flex justify-between mt-6'>
                <div>
                    <h6 className='font-medium text-red-400'>Company</h6>
                    <ul>
                        <li className='py-1 text-md'>Locations</li>
                        <li className='py-1 text-md'>Merch</li>
                        <li className='py-1 text-md'>Loyalty</li>
                        <li className='py-1 text-md'>Catering</li>
                    </ul>
                </div>
                <div>
                    <h6 className='font-medium text-red-400'>Support</h6>
                    <ul>
                        <li className='py-1 text-md'>Pricing</li>
                        <li className='py-1 text-md'>Nutrition</li>
                        <li className='py-1 text-md'>Allergy Information</li>
                        <li className='py-1 text-md'>FAQ</li>
                    </ul>
                </div>
                <div>
                    <h6 className='font-medium text-red-400'>Company</h6>
                    <ul>
                        <li className='py-1 text-md'>About</li>
                        <li className='py-1 text-md'>Blog</li>
                        <li className='py-1 text-md'>Jobs</li>
                        <li className='py-1 text-md'>Careers</li>
                    </ul>
                </div>
            </div>
        </div>
    );
};

export default Footer;