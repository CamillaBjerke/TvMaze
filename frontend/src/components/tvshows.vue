<template>
  <div class="TvShows">
    <h1>Serier</h1>
    <div class="content">
      <div class="mycard">
        <b-card-group deck v-for="res in results.data" :key="res.Id">
          <b-card
            :header="res.name"
            :img-src="res.image.medium"
            :img-alt="res.name"
            :img-width="80"
            img-top
            style="max-width: 15rem;"
            class="mb-3"
          >
            <b-card-text>
              <div>{{res.type}}</div>
              <div><span v-html="res.summary"></span></div>
            </b-card-text>
            <div slot="footer">
              <div>
                <font-awesome-icon icon="star" /> 
                {{ res.rating.average }}
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
            results: []
    }
  },
  async created(){
      this.results = await api.getAll();
  }
}
</script>

<style lang="scss">
  .content{ 
    margin: auto;
    width: 60%;
    padding: 10px;
  }
    .mycard{
        margin-top: 50px;
        display: flex;
        flex-wrap: wrap;
        justify-content: space-between;
    }
</style>