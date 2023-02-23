

export default function Hero() {

  return (
    <div className='flex items-center justify-center h-screen mb-12 bg-fixed bg-center bg-cover custom-img'>
      <div className='max-w-[800px] mt-[-96px] w-full h-screen mx-auto text-center flex flex-col justify-center'>
        <p className='text-[#00df9a] text-6xl font-bold p-2'>
          Kayaker Meetup
        </p>
        <div className='flex justify-center items-center'>
          <p className=' text-3xl font-bold py-4 text-gray-200'>
            A wonderful community full of passionate kayakers. Are you ready to join in on the fun?
          </p>
        </div>
        <p className=' text-xl font-bold text-gray-200'>Meetup and connect with local Kayakers near you</p>
        <button className='bg-[#00df9a] w-[200px] rounded-md font-medium my-6 mx-auto py-3 text-black'>Get Connected</button>
      </div>
    </div>
  )

}