<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MainMaster.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
 <div class="wrapper bgded" " style="background-image:url('../Files/Home/13.jpg');">
  <div id="pageintro" class="hoc clear">
    <!-- ################################################################################################ -->
    <article>
      <div class="overlay inspace-30 btmspace-30">
        <h2 class="heading">IIPS and ICCI Platform</h2>
        <p>This platform is one of the best ways to develop education institutions in order to provide an interactive learning environment that attracts students interest and encourages them to exchange views and experiences</p>
      </div>
      <footer>
        <ul class="nospace inline pushright">
          <li><a class="btn" href="#">Join Us</a></li>
          <li><a class="btn inverse" href="#">Courses</a></li>
        </ul>
      </footer>
    </article>
    <!-- ################################################################################################ -->
  </div>
</div>
       
    <div class="wrapper row3">
  <main class="hoc container clear">
    <!-- main body -->
    <!-- ################################################################################################ -->
    <div class="center btmspace-50">
      <h2 class="heading">About Our Services</h2>
      <p>E_learning approaches can combine different types of e_learning components</p>
    </div>
    <article class="one_third first btmspace-50">
      <h3 class="font-x1 btmspace-30"><i class="fa fa-2x fa-500px rightspace-10"></i> <a href="#">Interactive e-lessons</a></h3>
      <p>The most common approach for self-paced e-learning is Web-based training consisting of a set of interactive e-lessons. An e-lesson is a linear sequence of screens which can include text, graphics, animations, audio, video and interactivity in the form of questions and feedback. E-lessons can also include recommended reading and links to online resources, as well as additional information on specific topics.</p>

    </article>
    <article class="one_third  btmspace-50">
      <h3 class="font-x1 btmspace-30"><i class="fa fa-2x fa-adjust rightspace-10"></i> <a href="#">Electronic simulations</a></h3>
      <p>Simulations are highly interactive forms of e-learning.The term “simulation” basically means creating a learning environment that “simulates” the real world, allowing the learner to learn by doing. Simulations are a specific form of Web-based training that immerse the learner in a real‑world situation and respond in a dynamic way to his/her behaviour.</p>

    </article>
    <article class="one_third btmspace-50">
      <h3 class="font-x1 btmspace-30"><i class="fa fa-2x fa-leaf rightspace-10"></i> <a href="#">Virtual classroom </a></h3>
      <p>A virtual classroom is an e- learning event where an instructor teaches remotely and in real time to a group of learners using a combination of materials (e.g. PowerPoint slides, audio or video materials). It is also called synchronous learning. This method requires the least amount of effort to convert materials (but instructors still have to prepare them). Appropriate technology must be in place for both the learners and providers (e.g. software for the virtual classroom and good connectivity).</p>

    </article>
    <article class="one_third first">
      <h3 class="font-x1 btmspace-30"><i class="fa fa-2x fa-leanpub rightspace-10"></i> <a href="#">Online discussions</a></h3>
              <p>Synchronous and asynchronous online discussions are designed to facilitate communication and knowledge-sharing among learners. Learners can comment and exchange ideas about course activities or contribute to group learning by sharing their knowledge.</p>

    </article>
    <article class="one_third">
      <h3 class="font-x1 btmspace-30"><i class="fa fa-2x fa-legal rightspace-10"></i> <a href="#">Collaboration </a></h3>
      <p>Collaborative activities range from discussions and knowledge_sharing to working together on a common project. Social software, such as charts, discussion forums and blogs, are used for online collaboration among learners.Collaborative project work implies collaboration among learners to perform a task. </p>

    </article>
    <article class="one_third">
      <h3 class="font-x1 btmspace-30"><i class="fa fa-2x fa-pied-piper-alt rightspace-10"></i> <a href="#">E-tutoring, e-coaching, e-mentoring</a></h3>
      <p>E-tutoring, e-coaching and e-mentoring provide individual support and feedback to learners through online tools and facilitation techniques.&hellip;</p>
    </article>
    <!-- ################################################################################################ -->
    <!-- / main body -->
    <div class="clear"></div>
  </main>
</div>
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<div class="wrapper bgded overlay" style="background-image:url('../Files/Home/12.jpg');">
  <div class="hoc container clear">
    <!-- ################################################################################################ -->
    <article class="center">
      <h2 class="font-x3 uppercase">Do you have articles ?</h2>
      <p class="btmspace-50">Ac egestas at justo quisque lobortis ipsum sapien sed lacinia libero</p>
      <footer>
        <ul class="nospace inline pushright">
          <li><a class="btn inverse" href="#">publish</a></li>
          <li><a class="btn" href="#">send</a></li>
        </ul>
      </footer>
    </article>
    <!-- ################################################################################################ -->
  </div>
</div>
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<div class="wrapper row3">
  <section class="hoc container clear">
    <!-- ################################################################################################ -->
    <div class="center btmspace-50">
      <h2 class="heading">Last Article </h2>
      <p>Neque nisl id dictum nisi lacinia vel proin at dolor elit morbi sagittis turpis dolor.</p>
    </div>
    <ul class="nospace group">
      
          <asp:Repeater ID="Rpt_Articles" runat="server">
              <ItemTemplate>
                  <li class="one_third1">
                  <article class="element">
                      <figure><asp:Image ID="img_article" runat="server" AlternateText="" ImageUrl='<%# Bind("ArticlePhoto") %>' />
                           <figcaption><asp:HyperLink ID="hl_Article" runat="server" NavigateUrl='<%# "~/Pages/ArticleDetails?Article= "+Eval("ArticleId") %>'> <i class="fa fa-eye"></i></asp:HyperLink></figcaption>
           </figure>
                            <div class="excerpt">
            <h6 class="heading"><asp:Label ID="lbl_Article" runat="server" Text='<%# Eval("ArticleTitle") %>'></asp:Label></h6>
                          <time datetime="2045-04-05"><asp:Literal ID="ltr_Article" runat="server" Text='<%# Eval("ArticleDatePublish") %>'></asp:Literal> April 2045</time>
                 <p><asp:Label ID="lbl_Details" runat="server" Text='<%#Eval("ArticleDetails") %>'></asp:Label></p> 
                 <footer><asp:HyperLink ID="hy_readmore" runat="server" NavigateUrl='<%#"~/Pages/ArticleDetails?Article= "+Eval("ArticleId")  %>'>Read More &raquo;</asp:HyperLink></footer>         
                 </li>

              </ItemTemplate>
          </asp:Repeater>
      
    </ul>
    <!-- ################################################################################################ -->
  </section>
</div>
</asp:Content>

