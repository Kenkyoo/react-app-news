import React, { useState } from 'react';
import { nanoid } from 'nanoid';
import "animate.css/animate.compat.css";
import ScrollAnimation from 'react-animate-on-scroll';
import { motion } from "framer-motion"

function Cards({ data }) {
  console.log(data);
  const [selectedNews, setSelectedNews] = useState(null);

  if (selectedNews) {
    return (
    <motion.div
      initial={{ opacity: 0, scale: 0.5 }}
      animate={{ opacity: 1, scale: 1 }}
      transition={{ duration: 0.5 }} 
      className={"reader-container"}
    >
      <div className="card card-md bg-base-100 w-96 shadow-xl animate__animated animate__fadeIn">
        <figure className="px-10 pt-10">
          <img
            src={selectedNews.image_url}
            alt={selectedNews.title}
            className="rounded-xl"
          />
        </figure>
        <div className="card-body items-center text-center">
          <h2 className="card-title">{selectedNews.title}</h2>
          <h4 className='text-left'>{selectedNews.source_name}</h4>
          <p className='text-left'>{selectedNews.pubDate.split(" ")[0]}</p>
          <p>{selectedNews.description}</p>
          <div className="card-actions">
          <button className="btn btn-primary"><a href={selectedNews.link}>Leer nota completa</a></button>
          <button onClick={() => setSelectedNews(null)} className="btn btn-primary">Volver</button>
          </div>
        </div>
      </div>
    </motion.div>
    )
  }

  const boxs = data.map((news) => (
    <ScrollAnimation
      key={nanoid()}
      animateIn="fadeInUp"
      animateOut="fadeInOut"
    >
      <div className="card card-sm card-side bg-base-100 shadow-xl max-w-md mx-auto rounded-xl overflow-hidden md:max-w-2xl">
        <figure className='md:shrink-0'>
          <img className='h-48 w-full object-cover md:h-full md:w-48' src={news.image_url} alt={news.description} />
        </figure>
        <div className="card-body">
          <h2 className="card-title">{news.title}</h2>
          <p className="creator">{news.creator}</p>
          <div className="card-actions justify-center items-center">
            <p>{news.pubDate.split(" ")[0]}</p>
            <p>{news.category}</p>
            <button onClick={() => setSelectedNews(news)} className="btn btn-primary">
              Leer
            </button>
          </div>
        </div>
      </div>
    </ScrollAnimation>
  ));

  return (
  <>  
    <div className="card-container">
      {data ? boxs : "No data to display"}
    </div>
  </>  
  );
}

export default Cards;
