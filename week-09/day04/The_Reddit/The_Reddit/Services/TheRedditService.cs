using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using The_Reddit.Repositories;
using The_Reddit.Viewmodels;

namespace The_Reddit.Services
{
    public class TheRedditService
    {
        private TheRedditRepository theRedditRepository;

        public TheRedditService(TheRedditRepository theRedditRepository)
        {
            this.theRedditRepository = theRedditRepository;
        }

        //Itt kell a viewmodelt összerakni (postokhoz tartozó userek logikája jelenik meg benne)
        //Akkor van értelme a service-t használni, ha az itt szereplő kódblokkokat több helyen szeretnénk használni
        //így elkerülhető a kódduplikáció
        public TheRedditViewModel ViewDetails()
        {
            return new TheRedditViewModel()
            {
                Post = theRedditRepository.ShowList()
            };
        }

    }
}
