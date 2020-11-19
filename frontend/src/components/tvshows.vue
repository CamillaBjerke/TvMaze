<template>
  <div class="TvShows">
    <h1>Serier</h1>
    <div class="content">
      <span class="inline">
          <label for="serieType">Serie type</label>
          <select id="serieType" v-model="selectedType">
            <option v-for="type in optionsType" v-bind:key="type.text">
              {{ type.text }}
            </option>
          </select>
      </span>
      <div class="mycard">
       <b-card-group deck v-for="show in computed_items()" :key="show.Id"> 
          <b-card
            :header="show.name"
            :img-src="show.image.medium"
            :img-alt="show.name"
            :img-width="80"
            img-top            
            style="max-width: 15rem;"
            class="mb-3"
          >
            <b-card-text>
              <p>Type: {{show.type}}</p>
              <p>Språk: {{show.language}}</p>
            <div v-if="isSummary">
              {{show.summary | truncate(0, '')}}
              <p>
                <a v-if="show.summary.length> 0" @click="toggle()">
                  Les mer
                </a>
              </p>
            </div>
            <div v-else>
               <p>
                <a @click="toggle()">
                  {{ show.summary | truncate(1500, '...')}}
                </a>
              </p>                 
            </div>
             </b-card-text>
            <div slot="footer">
              <div>
                <font-awesome-icon icon="star" /> 
                {{ show.rating.average }}
                </div>
            </div>
            <small class="text-muted">
              </small>
          </b-card>
        </b-card-group>
        </div>
      </div>
    </div>
</template>


<script>
import api from '@/TvMazeApiService';

export default {
  name: 'Tvshows',
  data() {      
      return{
            selectedType: '',
            results: [],
            series: [],
            isSummary: true,
            optionsType: [
              { text: ''},
              { text: 'Scripted'},
              { text: 'Reality'},
              { text: 'Talk Show'},
              { text: 'Documentary' },                            
              { text: 'Animation'},              
              { text: 'Game Show'},              
              { text: 'News'},              
              { text: 'Sports'},                            
              { text: 'Variety' },                            
              { text: 'Panel Show'},                            
              { text: 'Award Show'},                            
            ]    
      }
  },
  async created(){
      this.results = await api.getAll();
      this.series = this.results.data;
  },
  methods:{
      toggle() {
        this.isSummary = !this.isSummary;
      },
      computed_items: function(){
        var vm = this;
        var type = vm.selectedType;
        
        if(type === ''){
          return this.series;
        }else{
          return this.series.filter(function(show) {
            return (show.type === type) 
            })
        }
      }
    }
  }

</script>

<style lang="scss">
p{
  a{
    font-weight: 400;
  }
}

</style>